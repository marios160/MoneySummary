using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            TransactionList = new List<Transaction>();
            CategoryKeyList = CategoryKeys.InitKeys();
            CategorySummaryListBinding = new BindingSource();


        }

        internal void Calculate()
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

                TransactionList.Add(new(item));
            }

            CategorySummaryList = new List<CategorySummary>();

            foreach (CategoryKeys c in CategoryKeyList)
            {
                CategorySummaryList.Add(new CategorySummary
                {
                    Category = c.Category.ToString(),
                    Amount = TransactionList.Where(t => t.Category == c.Category).Select(t => t.Amount).Sum()
                });
            }

            CategorySummaryListBinding.DataSource = CategorySummaryList;

        }
    }
}
