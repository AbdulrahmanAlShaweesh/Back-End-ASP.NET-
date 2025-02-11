using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Discounts
{
     
    internal class NullDiscount : Discount
    {
        public override string Name => "No Discount";

        public override double CalculateDiscount(double price, int quantity)
        {
            return 0;
        }
    }
}
