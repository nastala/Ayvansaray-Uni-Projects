using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model1();
            model.Students.Add(new Student { FirstName = "Ş", LastName = "Emre" });
            model.SaveChanges();

            foreach (var item in model.Students)
            {
                Console.WriteLine(item.FirstName + ' ' + item.LastName);
            }

            Console.ReadKey();
        }
    }
}
