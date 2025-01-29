using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    internal class Range<T> where T : IComparable<T>
    {
        #region Properities
        public T MaxValue { get; set; }
        public T MinValue { get; set; }
        #endregion

        #region Constructor
        public Range(T maxValue, T minValue)
        {
            this.MaxValue = maxValue;
            this.MinValue = minValue;
        }
        #endregion

        #region Methods
        public bool IsInRange(T value)
        {
            
            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0;
        }

        public T Length()
        {

            if (MaxValue is int x && MinValue is int y)
                return (T)(object)(x - y);
            if (MaxValue is double d1 && MinValue is double d2)
                return (T)(object)(d1 - d2);
            if (MaxValue is float f1 && MinValue is float f2)
                return (T)(object)(f1 - f2);
            if (MaxValue is long l1 && MinValue is long l2)
                return (T)(object)(l1 - l2);
            if (MaxValue is decimal m1 && MinValue is decimal m2)
                return (T)(object)(m1 - m2);

            throw new InvalidOperationException("Length() only supports numeric types.");
        }
 
        #endregion

    }
}
