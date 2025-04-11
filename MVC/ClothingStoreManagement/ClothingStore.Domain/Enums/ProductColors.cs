using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Enums
{
    [Flags]
    public enum ProductColors : byte
    {
        None = 0,
        Black = 1, 
        White = 2,
        Brown = 4,
        Yellow = 8,
        Beige = 16,
        Red = 32,
        LightBlue = 64,
        Pink =  128,
        OliveGreen =  255, 
     }
}
