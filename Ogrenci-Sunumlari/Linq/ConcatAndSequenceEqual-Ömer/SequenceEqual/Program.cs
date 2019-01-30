using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            var citiesA = new string[] { "Ankara", "İstanbul", "İzmir" };
            var citiesB = new string[] { "İstanbul", "Ankara", "İzmir" };
            var citiesC = new string[] { "Ankara", "İstanbul", "İzmir" };

            var aAndBEqual = citiesA.SequenceEqual(citiesB);
            var aAndCEqual = citiesA.SequenceEqual(citiesC);
            var bAndCEqual = citiesB.SequenceEqual(citiesC);

            Console.WriteLine("citiesA and citiesB are {0}equal.", aAndBEqual ? "" : "not ");
            Console.WriteLine("citiesA and citiesC are {0}equal.", aAndCEqual ? "" : "not ");
            Console.WriteLine("citiesB and citiesC are {0}equal.", bAndCEqual ? "" : "not ");
            Console.ReadKey();
        }
    }
}
