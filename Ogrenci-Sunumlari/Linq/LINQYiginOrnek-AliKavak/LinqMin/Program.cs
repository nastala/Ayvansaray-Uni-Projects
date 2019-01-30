using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 22, 55, 33, 2, 0, -20, 3, 33 };

            int EnKucukSayi = sayilar.Min();

            Console.WriteLine("Dizideki en küçük sayı = {0}", EnKucukSayi);

            Console.WriteLine("--------------------------------------------------");

            string[] Kelimeler = { "Ankara", "İstanbul", "İzmir", "Adana", "Antalya", "Bursa" };

            int KarakterSayisi = Kelimeler.Min(Kelime => Kelime.Length);
            string kisaKelime = Kelimeler.OrderBy(Kelime => Kelime.Length).FirstOrDefault();
            Console.WriteLine("Dizideki en kısa kelimede toplam {0} karakter var. Kelimemiz {1}", KarakterSayisi, kisaKelime);
            Console.ReadLine();
        }
    }
}
