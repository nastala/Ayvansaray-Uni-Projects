using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncExample
{
    class Program
    {
        private static event Func<int, double> Func;
        static void Main(string[] args)
        {
            Func += MultiplyBy2;
            Func += DivideBy2;

            Console.WriteLine(Func(6));
            Console.ReadKey();
        }
        private static double DivideBy2(int i)
        {
            return (double)i / 2;
        }
        private static double MultiplyBy2(int i)
        {
            return (double)i * 2;
        }
    }
}
