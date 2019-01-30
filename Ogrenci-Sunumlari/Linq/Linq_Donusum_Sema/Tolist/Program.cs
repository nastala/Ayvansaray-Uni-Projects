using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;

namespace Tolist
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler =Class1. OgrencileriGetir();

            // IEnumerable<int> OgrenciNotlari = from Ogrenci in Ogrenciler
            //                                     select Ogrenci.Notlar;
            // veya

            var OgrenciNotlari = from Ogrenci in Ogrenciler
                                 select Ogrenci.Notlar;

            // List<int> OgrenciNotlariListTListesi = OgrenciNotlari.ToList();
            // veya

            var OgrenciNotlariListTListesi = OgrenciNotlari.ToList();

            Console.WriteLine("List<T> (örnekte List<int[]>) sınıfına kopyalanmış öğrenci notları :");

            // foreach (int[] Notlar in OgrenciNotlariListTListesi) ...
            // veya

            foreach (var Notlar in OgrenciNotlariListTListesi)
            {
                // foreach (int Notu in Notlar)
                // veya

                foreach (var Notu in Notlar)
                {
                    Console.Write("{0} ", Notu);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //*************//

            //var Ogrenciler =Class1. OgrencileriGetir();

            //var OgrenciNotlari = Ogrenciler.Select(Ogrenci => Ogrenci.Notlar);

            //var OgrenciNotlariListTListesi = OgrenciNotlari.ToList();

            //Console.WriteLine("List<T> (örnekte List<int[]>) sınıfına kopyalanmış öğrenci notları :");

            //foreach (var Notlar in OgrenciNotlariListTListesi)
            //{
            //    foreach (var Notu in Notlar)
            //    {
            //        Console.Write("{0} ", Notu);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }
    }
}
