
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using LinqLect01;
using LinqLect01.Data;

namespace LinqAssig01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            // Fluent Syntex
            var Result01 = ListGenerator.ProductList
                                        .Where(P => P.UnitsInStock == 0);

            Result01 = from P in ListGenerator.ProductList
                       where P.UnitsInStock == 0
                       select P;
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item.ProductID);
            //}
            #endregion


            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            // Fluent Syntex

            var Result02 = ListGenerator.ProductList
                                        .Where(P => P.UnitsInStock > 0)
                                        .Where(P => P.UnitPrice > 3);
            Result02 = ListGenerator.ProductList.
                                    Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3.00M);


            // Query Syntex
            Result02 = from P in ListGenerator.ProductList
                       where P.UnitsInStock != 0 && P.UnitPrice > 3.00M
                       select P;

            //foreach(var item in Result02)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            string[] names = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // using indexed where
            var Result03 = names.Where((element, Index) => element.Length < Index);


            //foreach(var item in Result03)
            //{
            //    Console.WriteLine( item);
            //}

            #endregion


            #endregion









            #region  Element Operators

            #region 1. Get first Product out of Stock 
            var Result04 = ListGenerator.ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            var Result05 = (from P in ListGenerator.ProductList
                            where P.UnitsInStock == 0
                            select P).FirstOrDefault();

            //Console.WriteLine(Result05);
            #endregion

            #region 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            var Result06 = ListGenerator.ProductList.FirstOrDefault(P => P.UnitPrice > 1000);

            Result06 = (from P in ListGenerator.ProductList
                        where P.UnitPrice > 1000
                        select P).FirstOrDefault();

            //Console.WriteLine(Result06);
            #endregion

            #region 3. Retrieve the second number greater than 5 
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var Result07 = numbers.Where(P => P > 5).ElementAt(1);

            //Console.WriteLine(Result07);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array.
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result08 = Arr.Where(P => P % 2 == 0).Count();
            //Console.WriteLine(Result08);
            #endregion

            #region  2.0 Return a list of customers and how many orders each has
            var Result09 = ListGenerator.CustomerList.
                                         Select(C => new { C.CustomrName, Count = C.Orders.Count() });

            //foreach (var item in Result09)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 3.0 Return a list of categories and how many products each has
            var Result10 = ListGenerator.ProductList.GroupBy(P => P.Category).Select(g => new
            {
                Category = g.Key,
                Count = g.Key.Count()
            });



            //foreach ( var item in Result10)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4.0 Get the total of the numbers in an array.
            int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var Result11 = arr.Sum();
            //Console.WriteLine(Result11);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String Firs
            var words = File.ReadAllLines("dictionary_english.txt");

            var Result12 = words.Sum(E => E.Length);
            //Console.WriteLine(Result12);
            #endregion

            #region 6.0 Get the length  of the shortest  word in dictionary english.txt file
            var Result13 = words.Min(W => W.Length);
            //Console.WriteLine(Result13);
            #endregion
            #endregion

            #region 7.0 Get the length  of the shortest  word in dictionary english.txt file
            var Result14 = words.Max(W => W.Length);
            //Console.WriteLine(Result14);
            #endregion
            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name
            var Result = ListGenerator.ProductList.OrderBy(P => P.ProductName);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            String[] arr01 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            var Result002 = ListGenerator.ProductList.OrderBy(P => P.UnitPrice);
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr11 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Results01 = Arr11.OrderBy(D => D.Length).ThenBy(D => D);
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            String[] Arr111 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var reuslt11 = Arr111.OrderBy(P => P.Length).ThenBy(P => P);
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var Result011 = from P in ListGenerator.ProductList
                            orderby P.Category
                            orderby P.UnitPrice ascending
                            select P;
            //foreach(var item in Result011)
            //{
            //    Console.WriteLine(item);
            //}
            //ListGenerator.ProductList.OrderBy(P => P.Category).ThenBy(P => P.UnitPrice);
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            #endregion
            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            var result = ListGenerator.ProductList.Select(P => P.ProductName);
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            var reulsts = ListGenerator.ProductList.Select(P => new { UpperCase = P.ProductName.ToUpper(), LowerCase = P.ProductName.ToLower() });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            var result11 = ListGenerator.ProductList.Select(P => new { P.ProductName, P.UnitsInStock, Price = P.UnitPrice });

            //foreach (var item in result11)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            int[] arr11 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var result22 = (from a in numbersA
                            from b in numbersB
                            where a < b
                            select new { A = a, B = b }).ToList();

            #endregion

            #region  Select all orders where the order total is less than 500.00.
            var result23 = ListGenerator.CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500);
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            var result24 = ListGenerator.CustomerList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year >= 1998);
            #endregion
            #endregion
        }
    }
}
