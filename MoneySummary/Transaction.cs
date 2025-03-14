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
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public Category Category { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Recipient { get; set; }

        public Transaction(IXLRow row)
        {
            Date = DateTime.Parse(row.Cell((int)ExcelTemplate.Date).GetValue<string>());
            Amount = row.Cell((int)ExcelTemplate.Amount).GetValue<decimal>();
            Description1 = row.Cell((int)ExcelTemplate.Description1).GetValue<string>();
            string desc = row.Cell((int)ExcelTemplate.Description2).GetValue<string>();
            if (desc.IndexOf("Adres :") > 0)
                Description2 = desc[(desc.IndexOf("Adres :") + 7)..];
            else
                Description2 = desc;
            Description3 = row.Cell((int)ExcelTemplate.Description3).GetValue<string>();
            Description = $"{Description1} {Description2} {Description3}";
            Type = row.Cell((int)ExcelTemplate.Type).GetValue<string>();
            Recipient = row.Cell((int)ExcelTemplate.Recipient).GetValue<string>();
            Category = GetCategory();
        }

        public Category GetCategory()
        {
            foreach (CategoryKeys c in Controller.GetInstance().CategoryKeyList)
            {
                if (c.Keys.FirstOrDefault<string>(s => Recipient.ToLower().Contains(s.ToLower())) != null)
                {
                    return c.Category;
                }
                if (c.Keys.FirstOrDefault<string>(s => Type.ToLower().Contains(s.ToLower())) != null)
                {
                    return c.Category;
                }
                if (c.Keys.FirstOrDefault<string>(s => Description1.ToLower().Contains(s.ToLower())) != null)
                {
                    return c.Category;
                }
                if (c.Keys.FirstOrDefault<string>(s => Description2.ToLower().Contains(s.ToLower())) != null)
                {
                    return c.Category;
                }
                if (c.Keys.FirstOrDefault<string>(s => Description3.ToLower().Contains(s.ToLower())) != null)
                {
                    return c.Category;
                }

            }

            return Category.INNE;

        }
    }
}
