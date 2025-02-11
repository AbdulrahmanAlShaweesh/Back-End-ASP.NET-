using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Project.Discounts;

namespace Third_Project.Users
{
    internal class PremiumUser : User
    {
        public override string Name => "Premium User";

        public override Discount GetDiscount()
        {
           return new FlatDscount { FlatAmount = 100 };
        }
    }
}
