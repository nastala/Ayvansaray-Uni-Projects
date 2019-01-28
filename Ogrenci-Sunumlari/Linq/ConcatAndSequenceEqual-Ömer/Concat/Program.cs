using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat
{
    public static class IntArrayExtensions
    {
        public static IEnumerable<int> Concat2(this IEnumerable<int> first,
                                                     IEnumerable<int> second)
        {
            IEnumerator<int> array1 = first.GetEnumerator();
            IEnumerator<int> array2 = second.GetEnumerator();

            while (array1.MoveNext() && array2.MoveNext())
            {
                yield return array1.Current;
                yield return array2.Current;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenNumbers = { 0, 2, 4, 6, 8, 10 };
            int[] oddNumbers = { 1, 3, 5, 7, 9, 11 };

            //var allNumbers = oddNumbers.Concat(evenNumbers);
            var allNumbers = evenNumbers.Concat2(oddNumbers);

            Console.WriteLine("All Numbers:");

            var enumerator = allNumbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            //foreach (var number in allNumbers)
            //{
            //    Console.Write(number);
            //    Console.Write(" ");
            //}
            Console.ReadLine();
        }
    }
}
