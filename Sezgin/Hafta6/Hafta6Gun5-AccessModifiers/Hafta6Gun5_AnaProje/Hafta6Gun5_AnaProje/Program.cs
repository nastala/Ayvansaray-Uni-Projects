using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Gun5_AnaProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Classlar.Muhendis muhendis = new Classlar.Muhendis();
            Console.WriteLine(muhendis.MaasHesapla());
            // Console.WriteLine(muhendis.TamIsim()); Protected method olduğu için hata veriyor.
            Console.ReadLine();
        }
    }
}
