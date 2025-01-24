using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign04.Classes
{
    internal class DerivedClass2 : BaseClass
    {
        public new void DisplayMessage()
        {
            Console.WriteLine("Message From Derived Class 2");
        }
    }
}
