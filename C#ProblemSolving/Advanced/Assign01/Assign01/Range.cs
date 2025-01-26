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
            dynamic _min = MinValue;
            dynamic _max = MaxValue;

            return _max - _min;
        }

        public static Range<T> operator - (Range<T> left , Range<T> right)
        {
            return new Range() { 
               
            };
        }
        
        #endregion

    }
}
