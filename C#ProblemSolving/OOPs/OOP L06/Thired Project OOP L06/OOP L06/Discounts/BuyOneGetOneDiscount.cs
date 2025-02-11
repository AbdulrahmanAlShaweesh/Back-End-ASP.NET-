using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project.Discounts
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public override string Name => "Buy One Get One Free";

        public override double CalculateDiscount(double price, int quantity)
        {
            return price * (quantity / 2);  
        }
    }
}
