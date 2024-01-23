using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneySummary
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Recipient { get; set; }

        public Transaction(IXLRow row)
        {
            Date = row.Cell((int)ExcelTemplate.Date).GetDateTime();
            Amount = row.Cell((int)ExcelTemplate.Amount).GetValue<decimal>();
            string desc = row.Cell((int)ExcelTemplate.Description).GetValue<string>();
            if (desc.IndexOf("Adres :") > 0)
                Description = desc[(desc.IndexOf("Adres :") + 7)..];
            else
                Description = desc;
            Type = row.Cell((int)ExcelTemplate.Type).GetValue<string>();
            Recipient = row.Cell((int)ExcelTemplate.Recipient).GetValue<string>();
            Category = GetCategory();
        }

        private Category GetCategory()
        {
            foreach (CategoryKeys c in Controller.GetInstance().CategoryKeyList)
            {
                if (c.Keys.FirstOrDefault<string>(s => Recipient.ToLower().Contains(s.ToLower())) != null)
                {
                    return c.Category;
                }
                if (c.Keys.FirstOrDefault<string>(s => Type.ToLower().Contains(s.ToLower())) != null){
                    return c.Category;
                }
                if (c.Keys.FirstOrDefault<string>(s => Description.ToLower().Contains(s.ToLower())) != null)
                {
                    return c.Category;
                }

            }

            return Category.INNE;

        }
    }
}
