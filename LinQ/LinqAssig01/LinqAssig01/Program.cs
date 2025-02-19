
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using LinqLect01;

namespace LinqAssig01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            // Fluent Syntex
            var Resutl01 = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);

            // Query Syntex
            Resutl01 = from P in ListGenerator.ProductList
                     where P.UnitsInStock == 0
                     select P;
                     #endregion


            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            // Fluent Syntex
            var Result02 = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            Result02 = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.UnitPrice > 3);

            // Query Syntex
            Result02 = from P in ListGenerator.ProductList
                     where P.UnitsInStock > 0 && P.UnitPrice > 3
                     select P;
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            var Result03 = ListGenerator.ProductList.Where(P => P.ProductName.Length < P.UnitPrice).
                                                    Select(P => P.ProductID);

            Result03 = from P in ListGenerator.ProductList
                       where P.ProductName.Length < P.UnitPrice
                       select P.ProductID;
            #endregion

            //foreach (var item in Result03)
            //{
            //    Console.WriteLine(item);
            //}
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
            var Result06 = ListGenerator.ProductList?.FirstOrDefault(P => P.UnitPrice > 1000);

            //Console.WriteLine(Result06);
            #endregion

            #region 3. Retrieve the second number greater than 5 
            var Result07 = ListGenerator.ProductList.Where(P => P.UnitPrice > 5).
                                                    Skip(1).FirstOrDefault();

            //Console.WriteLine(Result07);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array.
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Resu01 = Arr.Where(P => P % 2 == 0).Count();
            //Console.WriteLine(Resu01);
            #endregion

            #region  2.0 Return a list of customers and how many orders each has
            var Resul02 = ListGenerator.CustomerList.SelectMany(P => P.Orders).Count();

            //Console.WriteLine(Resul02);

            #endregion

            #region 3.0 Return a list of categories and how many products each has
            var Resul03 = ListGenerator.ProductList.GroupBy(P => P.Category).Select(g => new
            {
                Category = g.Key , productCount = g.Count()
            });
            //Console.WriteLine(Resul03);
            //foreach (var item in Resul03)
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

            #endregion
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
            string[] Arr11 = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
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
            var names = ListGenerator.ProductList.Select(P => P.ProductName);

            var unitprice = ListGenerator.ProductList.Select(P => new
            {
                price = P.UnitPrice,
            });
            foreach(var name in unitprice)
            {
                Console.WriteLine(name);
            }
            #endregion
        }
    }
}
