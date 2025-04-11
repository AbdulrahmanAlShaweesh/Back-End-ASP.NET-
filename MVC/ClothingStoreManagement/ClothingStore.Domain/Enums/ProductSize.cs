using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Enums
{
    [Flags]
    public enum ProductSize : byte
    {
        None = 0,
        XS = 1, S = 2, M = 3, L = 4, XL = 5,
        XXL = 6, XXXL = 7
    }
}
