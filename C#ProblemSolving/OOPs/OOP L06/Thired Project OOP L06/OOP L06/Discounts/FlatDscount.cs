using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Discounts
{
    internal class FlatDscount : Discount
    {
        public override string Name => "Flat Discount";
        public double FlatAmount { get; set; }

        public override double CalculateDiscount(double price, int quantity)
        {
            return FlatAmount ;
        }
    }
}
