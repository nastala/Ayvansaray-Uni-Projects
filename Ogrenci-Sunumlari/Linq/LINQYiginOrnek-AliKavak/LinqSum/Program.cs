using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum İşlemi Kullanımı
            int[] sayilar = { 15, 24, 13, 35, 93, 81, 26, 47, 52, 90 };

            int toplam = sayilar.Sum();

            Console.WriteLine("Dizideki sayıların toplamı = {0}.", toplam);

            Console.WriteLine("-------------------------------------------------");
            //Dizideki kelimelerin uzunlukları Toplamı (METHOD SYNTAX) 
            string[] kelimeler = { "Ankara", "İstanbul", "İzmir", "Adana", "Antalya", "Bursa" };

            int toplamKarakterSayisi = kelimeler.Sum(kelime => kelime.Length);

            Console.WriteLine("Dizideki kelimelerde toplam {0} karakter var.", toplamKarakterSayisi);

            Console.ReadLine();
        }
    }
}
