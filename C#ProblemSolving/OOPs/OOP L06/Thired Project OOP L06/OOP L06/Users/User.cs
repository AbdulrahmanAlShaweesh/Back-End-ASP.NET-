using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Project.Discounts;

namespace Third_Project.Users
{
    internal abstract class User
    {
        public abstract string Name { get; }

        public abstract Discount GetDiscount();
    }
}
