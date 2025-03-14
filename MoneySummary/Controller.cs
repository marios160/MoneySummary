using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                XLWorkbook book = new XLWorkbook(FilePath);
                IXLWorksheet workSheet = book.Worksheet(1);



                bool firstRow = true;
                foreach (IXLRow item in workSheet.Rows())
                {
                    if (firstRow)
                    {
                        firstRow = false;
                        continue;
                    }
                    if(!item.IsEmpty())
                        TransactionList.Add(new(item));
                }

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
            if(!recalculate) TransactionList = new List<Transaction>();
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
