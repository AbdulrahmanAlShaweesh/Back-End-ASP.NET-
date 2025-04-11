using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Enums
{
    [Flags]
    public enum ProductStatus : byte
    {
        None = 0,
        InStock = 1,
        OutOfStock = 2,
        PreOrder = 4,
        Discontinued = 8, 
        OutOfSales = 16,
    }
}
