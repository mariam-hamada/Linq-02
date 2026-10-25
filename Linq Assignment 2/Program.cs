using LINQ.DataSources;
using LINQ.Models;
using System.Diagnostics.Metrics;
using System.Drawing;

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

            #region Question 11
            //11. Find the CHEAPEST and MOST EXPENSIVE product prices
            //var cheapest = Source.ProductList.Min(p => p.UnitPrice);
            //var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest: {cheapest}");
            //Console.WriteLine($"Most Expensive: {mostExpensive}");
            #endregion

            #region Question 12
            //12. Get a distinct list of all product categories
            //var result = Source.ProductList
            //.Select(p => p.Category)
            //.Distinct();

            //foreach (var category in result)
            //    Console.WriteLine(category);
            #endregion

            #region Question 13
            //13. find product IDs that are in setA but NOT in setB

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var id in result)
            //    Console.WriteLine(id);
            #endregion

            #region Question 14
            //14. Find countries that appear in list1 but NOT in list2 (case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(
            //    list2,
            //    StringComparer.OrdinalIgnoreCase
            //);

            //foreach (var country in result)
            //    Console.WriteLine(country);

            #endregion

            #region Question 15
            //15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //Dictionary<int, Product> productsDictionary =
            //Source.ProductList.ToDictionary(p => p.ProductID);

            //if (productsDictionary.TryGetValue(18, out Product product))
            //{
            //    Console.WriteLine($"{product.ProductID} - {product.ProductName}");
            //}
            #endregion

            #region Question 16
            //16. Get the first product whose price is greater than $50.
            //var result = Source.ProductList
            //.First(p => p.UnitPrice > 50);

            //Console.WriteLine($"{result.ProductName} - {result.UnitPrice}");
            #endregion

            #region Question 17
            //17. Try to get the first product with a price > $500. it returns null instead of throwing.
            //var result = Source.ProductList
            //.FirstOrDefault(p => p.UnitPrice > 500);

            //if (result != null)
            //    Console.WriteLine(result.ProductName);
            //else
            //    Console.WriteLine("No product found");
            #endregion

            #region Question 18
            //18. Generate a multiplication table row for 7
            //var result = Enumerable.Range(1, 10)
            //.Select(n => $"7 x {n} = {7 * n}");

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Question 19
            //19. Generate even numbers between 1 and 30.
            //var result = Enumerable.Range(1, 30)
            //.Where(n => n % 2 == 0);

            //foreach (var n in result)
            //    Console.WriteLine(n);
            #endregion

            #region Question 20
            //20. Concatenate the first 3 product names with the first 3 customer company names into a single sequence.
            //var result = Source.ProductList
            //.Take(3)
            //.Select(p => p.ProductName)
            //.Concat(
            //    Source.CustomerList
            //        .Take(3)
            //        .Select(c => c.CustomerName)
            //);

            //foreach (var name in result)
            //    Console.WriteLine(name);
            #endregion

            #region Question 21
            //21. Pair each product with a customer (by position) and produce a string "ProductName sold to CompanyName".
            //var result = Source.ProductList
            //.Zip(
            //    Source.CustomerList,
            //    (p, c) => $"{p.ProductName} sold to {c.CustomerName}"
            //);

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion
        }
    }
}
