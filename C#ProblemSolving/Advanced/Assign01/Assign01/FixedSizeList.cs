using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    internal class FixedSizeList<T>
    {

        #region Properity
        private readonly T[] items;
        public int ListSize; 
        #endregion

        #region Constructor
        public FixedSizeList(int capacity)
        {
            items = new T[capacity];
            ListSize = 0;
        }
        #endregion

        #region Methods
        public void Add(T item)
        {
            if(ListSize > items.Length)
            {
                throw new InvalidOperationException("list is full, so space");
            }
            items[ListSize] = item;
            ListSize++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= ListSize)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }

            return items[index];
        }

        // return the elemen index
        public int Count()
        {
            return ListSize;
        }

        // return the total array's capasity
        public int Capacity()
        {
            return items.Length;
        }
        #endregion
    }
}
