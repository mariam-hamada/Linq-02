using LINQ.DataSources;
using LINQ.Models;

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
        }
    }
}
