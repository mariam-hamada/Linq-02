using LINQ.DataSources;
using LINQ.Models;
using System.Diagnostics.Metrics;

namespace Linq_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1
            //1. Get top 3 most expensive products
            //var result = Source.ProductList
            //.OrderByDescending(p => p.UnitPrice)
            //.Take(3);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion

            #region Question 2
            //2. show page 2 of products, with page size = 5
            //var result = Source.ProductList
            //.Skip(5)
            //.Take(5);

            //foreach (var p in result)
            //    Console.WriteLine(p.ProductName);


            #endregion

            #region Question 3
            //3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var result = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            #endregion

            #region Question 4
            //4. Check if ALL products in the "Seafood" category are in stock
            //bool result = Source.ProductList
            //.Where(p => p.Category == "Seafood")
            //.All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);

            #endregion

            #region Question5
            //5. Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };

            //int[] ids = { 3, 9, 13, 18 };

            //bool result = ids.Contains(9);

            //Console.WriteLine(result);
            #endregion

            #region Question 6
            ////6. Group all products by Category and print each group with its product count.
            //var result = Source.ProductList
            //.GroupBy(p => p.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"{group.Key}: {group.Count()} products");
            //}
            #endregion

            #region Question 7
            //7. Group products by Category and project only product names per group
            // var result = Source.ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //        {
            //            Category = g.Key,
            //            ProductNames = g.Select(p => p.ProductName)
            //        });

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);

            //    foreach (var name in group.ProductNames)
            //        Console.WriteLine(name);
            //}
            #endregion

            #region Question 8
            //8. Find all categories that have MORE THAN 3 products
            //var result = Source.ProductList
            //.GroupBy(p => p.Category)
            //.Where(g => g.Count() > 3)
            //.Select(g => g.Key);

            //foreach (var category in result)
            //    Console.WriteLine(category);
            #endregion

            #region Question 9
            //9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var result =
            //from c in Source.CustomerList
            //group c by c.Country into g
            //select new
            //{
            //    Country = g.Key,
            //    Count = g.Count(),
            //    TotalOrderValue = g
            //        .SelectMany(c => c.Orders)
            //        .Sum(o => o.Total)
            //};

            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"{item.Country} - Customers: {item.Count}, " +
            //        $"Total Orders: {item.TotalOrderValue}");
            //}
            #endregion

            #region Question 10
            //10. Calculate the total number of units in stock across all products
            //int result = Source.ProductList
            //.Sum(p => p.UnitsInStock);

            //Console.WriteLine(result);
            #endregion
        }
    }
}
