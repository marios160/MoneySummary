using ExcelDataReader;

namespace MoneySummary
{
    public class Controller
    {
        private static Controller _instance;
        public string FilePath { get; set; }
        public List<Transaction> TransactionList { get; set; }

        public List<CategoryKeys> CategoryKeyList { get; set; }
        public List<CategorySummary> CategorySummaryList { get; set; }

        public BindingSource CategorySummaryListBinding { get; set; }
        public BindingSource CategoryPositionListBinding { get; set; }

        public decimal Sum { get; set; }


        public static Controller GetInstance()
        {
            if (_instance == null)
                _instance = new Controller();

            return _instance;
        }

        public static void Destroy()
        {
            _instance = null;
        }
        public Controller()
        {
            CategoryKeyList = CategoryKeys.InitKeys();
            Clear();

        }

        internal void Calculate()
        {
            //Clear();
            try
            {

                TransactionList.AddRange(ReadExcelFile(FilePath));

                CategorySummaryList = new List<CategorySummary>();

                foreach (CategoryKeys c in CategoryKeyList)
                {
                    var monthlySummary = TransactionList
                       .Where(t => t.Category == c.Category)  // Filtruj transakcje po kategorii
                       .GroupBy(t => new DateTime(t.Date.Year, t.Date.Month, 1)) // Grupowanie po miesiącu
                       .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));  // Tworzenie słownika {Miesiąc -> Suma}

                    CategorySummaryList.Add(new CategorySummary
                    {
                        Category = c.Category.ToString(),
                        Amounts = monthlySummary
                    });
                }

                CategorySummaryListBinding.DataSource = CategorySummaryList;

                Sum = CategorySummaryList.Where(x => x.Category != Category.PRZELEW_WEW.ToString()).Sum(x => x.Amounts.Sum(c => c.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        static List<Transaction> ReadExcelFile(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            var transactions = new List<Transaction>();

            using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);

            var dataSet = reader.AsDataSet();
            var table = dataSet.Tables[0]; // pierwsza zakładka Excela

            for (int i = 1; i < table.Rows.Count; i++) // pomiń nagłówek
            {
                var row = table.Rows[i];

                if (row.ItemArray.Length < 10) continue;

                transactions.Add(new(row));

            }

            return transactions;
        }

        internal void Recalculate()
        {
            CategoryKeyList = CategoryKeys.InitKeys();
            Clear(true);
            try
            {
                foreach (Transaction t in TransactionList)
                    t.Category = t.GetCategory();

                CategorySummaryList = new List<CategorySummary>();

                foreach (CategoryKeys c in CategoryKeyList)
                {

                    var monthlySummary = TransactionList
                       .Where(t => t.Category == c.Category)  // Filtruj transakcje po kategorii
                       .GroupBy(t => new DateTime(t.Date.Year, t.Date.Month, 1)) // Grupowanie po miesiącu
                       .ToDictionary(g => g.Key, g => g.Sum(t => t.Amount));  // Tworzenie słownika {Miesiąc -> Suma}

                    CategorySummaryList.Add(new CategorySummary
                    {
                        Category = c.Category.ToString(),
                        Amounts = monthlySummary
                    });
                }

                CategorySummaryListBinding.DataSource = CategorySummaryList;

                Sum = CategorySummaryList.Where(x => x.Category != Category.PRZELEW_WEW.ToString()).Sum(x => x.Amounts.Sum(c => c.Value));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear(bool recalculate = false)
        {
            if (!recalculate) TransactionList = new List<Transaction>();
            CategorySummaryListBinding = new BindingSource();
            CategoryPositionListBinding = new BindingSource();
            Sum = 0;
        }

        internal void GetPositions(string category)
        {
            CategoryPositionListBinding.DataSource = TransactionList.Where(t => t.Category.ToString().Equals(category)).OrderByDescending(o => o.Date);
        }
    }
}
