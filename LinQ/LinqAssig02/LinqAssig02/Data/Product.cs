using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLect01.Data
{
    internal class Product
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"Product Id {ProductID}, Product Name: {ProductName}, Category {Category}, Unit Price {UnitPrice}, Unit In Stack {UnitsInStock}";
        }
    }
}
