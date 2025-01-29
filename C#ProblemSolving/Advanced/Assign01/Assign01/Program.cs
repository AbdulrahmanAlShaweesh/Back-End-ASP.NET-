using System.Collections;

namespace Assign01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            Range<int>? RangeValue01 = new Range<int>(minValue: 10, maxValue: 32);

            Console.WriteLine(RangeValue01.IsInRange(10));   // True (10 in the range of 10, and 32
            Console.WriteLine(RangeValue01.IsInRange(5));    // False (5 is not in the range of 10, and 32(
            Console.WriteLine(RangeValue01.Length());
            Console.WriteLine($"{new string('*' , 40)}");
            Range<double>? RangeValue02 = new Range<double>(minValue: 32.2, maxValue: 88.3); 
            Console.WriteLine(RangeValue02.IsInRange(73.4));   // True (10 in the range of 10, and 32
            Console.WriteLine(RangeValue02.IsInRange(5.32));    // False (5 is not in the range of 10, and 32(
            Console.WriteLine(Math.Round(RangeValue02.Length(), 3));
            #endregion

            #region Question 2 : Reverse Array List
            ArrayList myArray = new ArrayList { 1, 2, 3, 4, 5, 6, 7 };
            Reverse<int> reverse = new Reverse<int>();

            Console.WriteLine($"{new string('*', 20)} This is the Orignal array {new string('*', 20)}");
            foreach (int item in myArray)
            {
                Console.Write(item   + " ");
            }

            Console.WriteLine();
            reverse.ReverseArray(myArray);
            Console.WriteLine($"{new string('*', 20)} This is after reversing the array {new string('*', 20)}");
            foreach(int item in myArray)
            {
                Console.Write(item + " ");
            }
            #endregion

            #region Question 3 : Get the event number
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> eventNumbers =  EventNumbers.GetEventNumbers(Numbers);
            foreach(int number in eventNumbers)
            {
                Console.WriteLine($"{number}");
            }
            #endregion

            #region Question 4 FixedSize list
            FixedSizeList<int> fixedList = new FixedSizeList<int>(3); // Set capacity to 3

            fixedList.Add(10);
            fixedList.Add(20);
            fixedList.Add(30);
            Console.WriteLine("Element at index 1: " + fixedList.Get(1));
            Console.WriteLine($"{fixedList.Get(1)} located at {fixedList.Count()}");
            Console.WriteLine($"The total element stored in the array is {fixedList.Capacity()}");
            #endregion

            #region Question 5 : 

            #endregion
        }
    }
}
