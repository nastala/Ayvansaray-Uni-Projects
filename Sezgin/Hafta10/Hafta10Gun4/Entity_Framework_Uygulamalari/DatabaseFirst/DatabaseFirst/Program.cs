using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new NorthwindEntities();

            var result = from product in db.Products
                         join category in db.Categories on product.CategoryID equals category.CategoryID
                         select new
                         {
                             product.ProductName,
                             category.CategoryName
                         };

            foreach (var resultItem in result)
            {
                Console.WriteLine(resultItem.ProductName + "\t -> " + resultItem.CategoryName);
            }

            Console.ReadKey();
        }
    }
}
