using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Enums
{
    [Flags]
    public enum Gender : byte
    {
        None = 0,
        Male = 1,
        Female = 2,
    }
}
