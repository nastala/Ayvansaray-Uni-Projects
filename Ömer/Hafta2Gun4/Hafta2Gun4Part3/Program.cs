using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4Part3
{
    class Program
    {
        static uint Recursive(uint prevNumber, uint currentNumber, int count)
        {
            Console.WriteLine(prevNumber + currentNumber);
            if (count >= 100)
            {
                return prevNumber + currentNumber;
            }
            var temp = currentNumber;
            currentNumber += prevNumber;
            prevNumber = temp;
            return Recursive(prevNumber, currentNumber, ++count);
        }
        static void Main(string[] args)
        {
            uint prev = 0;
            uint cur = 1;
            int count = 0;
            Recursive(prev, cur, count);

            Console.ReadKey();
        }
    }
}
