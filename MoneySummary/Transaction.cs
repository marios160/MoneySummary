using ClosedXML.Excel;
using System.Data;

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

        public Transaction(DataRow row)
        {
            Date = DateTime.Parse(row[(int)ExcelTemplate.Date].ToString());
            Amount = decimal.Parse(row[(int)ExcelTemplate.Amount].ToString());
            Description1 = row[(int)ExcelTemplate.Description1].ToString();
            string desc = row[(int)ExcelTemplate.Description2].ToString();
            if (desc.IndexOf("Adres :") > 0)
                Description2 = desc[(desc.IndexOf("Adres :") + 7)..];
            else
                Description2 = desc;
            Description3 = row[(int)ExcelTemplate.Description3].ToString();
            Description = $"{Description1} {Description2} {Description3}";
            Type = row[(int)ExcelTemplate.Type].ToString();
            Recipient = row[(int)ExcelTemplate.Recipient].ToString();
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
