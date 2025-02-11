using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Discounts
{
    internal class PerecentageDiscount : Discount
    {
        public override string Name => "Percentage Discount";
        public double Percentage { get; set; }

        public override double CalculateDiscount(double price, int quantity)
        {
            return price * quantity * (Percentage / 100);
        }
    }
}
