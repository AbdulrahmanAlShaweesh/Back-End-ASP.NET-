using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Project.Discounts;

namespace Third_Project.Users
{
    internal class RegularUser : User
    {
        public override string Name => "Regular User";

        public override Discount GetDiscount()
        {
            return new PerecentageDiscount { Percentage = 5 };
        }
    }
}
