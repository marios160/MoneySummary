using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySummary
{
    public class CategorySummary
    {
        public string Category { get; set; }
        public Dictionary<DateTime, decimal> Amounts { get; set; }
    }
}
