using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1OOPs.Enums
{
    [Flags]
    internal enum Permissions
    {
        // Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum           .
       //  Create Variable from previous Enum to Add and Remove Permission from variable,
       //  check if specific Permission existed inside variable
       Read = 1,
       Write = 2,
       Delete = 4, 
       Execute = 8,
    }
}
