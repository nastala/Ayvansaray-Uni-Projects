using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountConditionaSituation
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var OgrenciNotSayilari = from Ogrenci in Ogrenciler
                                     select new { Ogrenci.Adi, Ogrenci.Soyadi, NotAdedi = Ogrenci.Notlar.Count() };

            Console.WriteLine("Öğrenciler ve not sayıları :");

            foreach (var Nesne in OgrenciNotSayilari)
            {
                Console.WriteLine("{0} {1}, not adedi : {2}", Nesne.Adi, Nesne.Soyadi, Nesne.NotAdedi);
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            // LINQ Yöntem Sözdizimi (LINQ Method Syntax)
            var OgrenciNotSayilariMS = Ogrenciler.Select(Ogrenci => new { Ogrenci.Adi, Ogrenci.Soyadi, NotAdedi = Ogrenci.Notlar.Count() });

            Console.WriteLine("Öğrenciler ve not sayıları :");

            foreach (var Nesne in OgrenciNotSayilariMS)
            {
                Console.WriteLine("{0} {1}, not adedi : {2}", Nesne.Adi, Nesne.Soyadi, Nesne.NotAdedi);
            }
            Console.ReadLine();
        }
    }
}
