using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Anagramlar = { "şart", "yumak", "antik", "traş", "yamuk", "nakit" };

            var AnagramGruplari = Anagramlar.GroupBy(Kelime => Kelime, new AnagramEsitlikKarsilastirici());

            Console.WriteLine("Dizideki anagramlar :");
            foreach (var Grup in AnagramGruplari)
            {
                Console.WriteLine("---");
                foreach (var Kelime in Grup)
                {
                    Console.WriteLine(Kelime);
                }
            }
            Console.ReadLine();
        }
    }
    
    

}
