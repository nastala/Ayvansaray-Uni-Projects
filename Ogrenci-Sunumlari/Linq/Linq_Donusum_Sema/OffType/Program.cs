using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;
namespace OffType
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] Degerler = { 3.0, null, "beş", 3, "dört", 5, "altı", 7.1 };

            var CiftDuyarliklilar = Degerler.OfType<double>();

            Console.WriteLine("Dizide çift duyarlıklı (double) olarak tutulan değerler :");

            foreach (var Deger in CiftDuyarliklilar)
            {
                Console.WriteLine(Deger);
            }
            Console.ReadLine();
        }
    }
}
