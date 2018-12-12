using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Hafta4Gun3Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            KareleriSeveriz kareler = new KareleriSeveriz();
            foreach (double kare in kareler)
            {
                Console.WriteLine(kare);
                Thread.Sleep(100);
            }
        }
    }

    class KareleriSeveriz : IEnumerable
    {
        private KareleriSeverizIEnumerator iter;

        public KareleriSeveriz()
        {
            iter = new KareleriSeverizIEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return iter;
        }
    }

    class KareleriSeverizIEnumerator : IEnumerator
    {
        private int currentNumber;
        private double kare;

        public KareleriSeverizIEnumerator()
        {
            Reset();
        }

        public object Current { get { return kare; } }

        public bool MoveNext()
        {
            kare = Math.Pow(currentNumber, 2);
            currentNumber++;

            return true;
        }

        public void Reset()
        {
            currentNumber = 0;
            kare = 0;
        }
    }
}
