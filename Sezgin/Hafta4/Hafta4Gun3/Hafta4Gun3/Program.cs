using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Gun3
{
    class Program
    {
        //Hafta 4, Gün 3, Part 1, Fibonacci IEnum <-----> 12.12.2018

        static void Main(string[] args)
        {
            FibonacciNumbers f = new FibonacciNumbers(200000);
            foreach (int n in f)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }

    class FibonacciNumbers : IEnumerable
    {
        private FibonacciIEnumerator iter;

        public FibonacciNumbers(int max)
        {
            iter = new FibonacciIEnumerator(max);
        }

        public IEnumerator GetEnumerator()
        {
            return iter;
        }
    }

    class FibonacciIEnumerator : IEnumerator
    {
        private int currentNumber, nextNumber, maxNumber;

        public FibonacciIEnumerator(int max)
        {
            maxNumber = max;
            Reset();
        }

        public object Current { get { return currentNumber; } }

        public bool MoveNext()
        {
            int newNextNumber = currentNumber + nextNumber;
            currentNumber = nextNumber;
            nextNumber = newNextNumber;

            return currentNumber <= maxNumber;
        }

        public void Reset()
        {
            currentNumber = 0;
            nextNumber = 1;
        }
    }
}
