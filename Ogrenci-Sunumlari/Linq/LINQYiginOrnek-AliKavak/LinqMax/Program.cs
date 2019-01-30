using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 22, 55, 33, 2, 0, -20, 3, 33 };

            int EnBuyukSayi = sayilar.Max();

            Console.WriteLine("Dizideki en büyük sayı = {0}", EnBuyukSayi);

            Console.WriteLine("-------------------------------------------------------");

            string[] Kelimeler = { "Ankara", "İstanbul", "İzmir", "Adana", "Antalya", "Bursa" };

            int KarakterSayisi = Kelimeler.Max(Kelime => Kelime.Length);
            string uzunKelime = Kelimeler.OrderByDescending(Kelime => Kelime.Length).FirstOrDefault();

            Console.WriteLine("Dizideki en uzun kelimede toplam {0} karakter var.Kelimemiz : {1}", KarakterSayisi,uzunKelime);

            Console.ReadLine();

        }
    }
}
