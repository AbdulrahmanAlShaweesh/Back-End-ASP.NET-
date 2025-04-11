using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Enums
{
    [Flags]
    public enum ProductType : byte
    {
        None = 0,
        Shirt = 1,
        Pants = 2,
        Jacket = 4,
        Skirt = 8,
        Dress = 16,
        TShirt = 32,
        Shorts = 64,
        Sweater = 128,
        Jeans = Shirt | Pants,  // Combining Shirt and Pants as a Jeans category
        Blouse = Shirt | Dress, // Combining Shirt and Dress for Blouse category
        Hoodie = Jacket | Sweater // Combining Jacket and Sweater for Hoodie category
    }
}
