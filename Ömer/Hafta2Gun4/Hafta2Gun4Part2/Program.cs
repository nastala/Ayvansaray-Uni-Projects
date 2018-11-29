using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberBefore = 0;
            uint tempBefore = 0;
            uint i = 1;
            for (int count = 0; count < 100; count++)
            {
                Console.WriteLine(i);
                tempBefore = i;
                i += numberBefore;
                numberBefore = tempBefore;
            }

            Console.ReadKey();
        }
    }
}
