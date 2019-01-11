using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        private delegate int MyDelegate(string s);
        private static event MyDelegate Converter;
        static void Main(string[] args)
        {
            Converter += Program_Converter;
            Console.WriteLine(Converter("8"));
            Console.ReadKey();
        }

        private static int Program_Converter(string s)
        {
            return int.Parse(s);
        }
    }
}
