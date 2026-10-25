using LINQ.DataSources;

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
        }
    }
}
