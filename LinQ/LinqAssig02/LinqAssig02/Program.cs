using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using LinqLect01;
using LinqLect01.Data;

namespace LinqAssig02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators

            #region 1. Get the total units in stock for each product category.
            var totalStockByCategory = from p in ListGenerator.ProductList
                                       group p by p.Category into grouped
                                       select new
                                       {
                                           Category = grouped.Key,
                                           TotalUnitsInStock = grouped.Sum(x => x.UnitsInStock)
                                       };

            foreach (var item in totalStockByCategory)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region 2. Get the cheapest price among each category's products
            var cheapestPriceByCategory = from p in ListGenerator.ProductList
                                          group p by p.Category into grouped
                                          select new
                                          {
                                              Category = grouped.Key,
                                              CheapestPrice = grouped.Min(x => x.UnitPrice)
                                          };
            #endregion

            #region 3. Get the products with the cheapest price in each category (Use Let)
            var cheapestProductsByCategory = from p in ListGenerator.ProductList
                                             group p by p.Category into grouped
                                             let cheapestPrice = grouped.Min(x => x.UnitPrice)
                                             from product in grouped
                                             where product.UnitPrice == cheapestPrice
                                             select new
                                             {
                                                 Category = grouped.Key,
                                                 ProductName = product,
                                                 CheapestPrice = cheapestPrice
                                             };
            foreach (var item in totalStockByCategory) Console.WriteLine(item);
            #endregion

            #region 4. Get the most expensive price among each category's products.
            var mostExpensivePriceByCategory = from p in ListGenerator.ProductList
                                               group p by p.Category into grouped
                                               select new
                                               {
                                                   Category = grouped.Key,
                                                   MostExpensivePrice = grouped.Max(x => x.UnitPrice)
                                               };
            foreach (var item in totalStockByCategory) Console.WriteLine(item);
            #endregion

            #region 5. Get the products with the most expensive price in each category.
            var mostExpensiveProductsByCategory = from p in ListGenerator.ProductList
                                                  group p by p.Category into grouped
                                                  let maxPrice = grouped.Max(x => x.UnitPrice)
                                                  from product in grouped
                                                  where product.UnitPrice == maxPrice
                                                  select new
                                                  {
                                                      Category = grouped.Key,
                                                      ProductName = product.ProductName,
                                                      Price = product.UnitPrice
                                                  };
            foreach (var item in totalStockByCategory) Console.WriteLine(item);
            #endregion

            #region 6. Get the average price of each category's products.
            var averagePriceByCategory = from p in ListGenerator.ProductList
                                         group p by p.Category into grouped
                                         select new
                                         {
                                             Category = grouped.Key,
                                             AveragePrice = grouped.Average(x => x.UnitPrice)
                                         };
            foreach (var item in totalStockByCategory) Console.WriteLine(item);
            #endregion
            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            var uniqueCategories = ListGenerator.ProductList
                                                .Select(p => p.Category)   // Select only the Category property
                                                .Distinct();

            foreach (var item in uniqueCategories) Console.WriteLine(item);
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            var resutl01 = ListGenerator.ProductList.Select(P => P.ProductName[0]);
            var ersult02 = ListGenerator.CustomerList.Select(C => C.CustomrName[0]);

            var resutl = resutl01.Union(ersult02);

            foreach (var item in resutl) Console.WriteLine(item);
            #endregion.

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            var resutl03 = ListGenerator.ProductList.Select(P => P.ProductName[0]);
            var rersult04 = ListGenerator.CustomerList.Select(C => C.CustomrName[0]);

            var resutl1 = resutl03.Intersect(rersult04);

            foreach (var item in resutl1) Console.WriteLine(item);
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var productFirstLetters = ListGenerator.ProductList
                                                    .Select(p => p.ProductName[0]);  

            var customerFirstLetters = ListGenerator.CustomerList
                .Select(c => c.CustomrName[0]);   

            var result = productFirstLetters
                .Except(customerFirstLetters)  
                .Distinct();  // Ensure uniqueness

            foreach(var item in result) Console.WriteLine(item);
            #endregion


            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            var resultss = ListGenerator.ProductList.Select(P => P.ProductName.Length >= 3 ? P.ProductName.Substring(P.ProductName.Length - 3) : P.ProductName);

            var resultss1 = ListGenerator.ProductList.Select(P => P.ProductName.Length >= 3 ? P.ProductName.Substring(P.ProductName.Length - 3) : P.ProductName);

            var Resutls = resultss.Concat(resultss1);

            foreach(var item in Resutls) Console.WriteLine(item);
            #endregion
            #endregion

            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington
            var CustomersResult = ListGenerator.CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Take(3);

            foreach(var item in CustomersResult) Console.WriteLine(item);
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            var allCustomers = ListGenerator.CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders);
            foreach(var item in allCustomers) Console.WriteLine(item);

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result01s = numbers.TakeWhile((num, i) => num > i);

            foreach(var item in result01s) Console.WriteLine(item);
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            int[] numberss = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resulltsss = numberss.SkipWhile((num, index) => num % index != 0);

            foreach (var item in resulltsss) Console.WriteLine(item);
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            int[] numbers111 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var ressuk = numbers111.SkipWhile((num, index) => num > index);

            foreach(var item in ressuk) Console.WriteLine(item);
            #endregion
            #endregion

            #region LINQ – Grouping Operators

            #region Use group by to partition a list of numbers by their remainder when divided by 5
            List<int> numberssss = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var groupedByRemainder = from number in numberssss
                                     group number by number % 5 into remainderGroup
                                     select new
                                     {
                                         Remainder = remainderGroup.Key,
                                         Numbers = remainderGroup
                                     };
            foreach(var item in groupedByRemainder) Console.WriteLine(item);
            #endregion

            #region Consider this Array as an Input
            String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            // Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            var groupedWords = Arr
            .GroupBy(word => string.Concat(word.OrderBy(c => c)))  // Sort characters in the word
            .OrderBy(group => group.Key);

            foreach(var item in groupedWords) Console.WriteLine(item);

            #endregion
            #endregion

        }
    }
}
