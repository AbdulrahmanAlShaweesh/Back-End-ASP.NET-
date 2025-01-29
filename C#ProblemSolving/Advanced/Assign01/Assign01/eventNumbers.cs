using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    internal static class EventNumbers
    {
        public static List<int> GetEventNumbers(List<int> numbers)
        {
            List<int> eventNumberArray = new List<int>();
            if (numbers is null)
            {
                return new List<int>();
            }
             
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    eventNumberArray.Add(numbers[i]);
                }
            }
            return eventNumberArray;
            
        }
    }
}
