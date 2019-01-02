using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Gun1_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            TarihBilgisi tarihBilgisi = new TarihBilgisi();
            tarihBilgisi.GecerliTarih = "25-11-1995";
            Console.WriteLine(tarihBilgisi.GunOlarakTarihFarki(DateTime.Now));
            Console.ReadLine();
        }
    }
}
