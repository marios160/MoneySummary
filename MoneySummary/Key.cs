using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySummary
{
    public class Key
    {
        public string Field { get; set; }
        public string Value { get; set; }

        public Key(string field, string value)
        {
            Field = field;
            Value = value;
        }
    }
}
