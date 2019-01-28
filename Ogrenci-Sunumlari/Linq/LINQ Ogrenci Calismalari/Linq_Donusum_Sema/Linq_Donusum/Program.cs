using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;


namespace Linq_Donusum
{
    //internal static class Extensions
    //{
    //    public static void Change(this string oldValue, string newValue)
    //    {
    //        oldValue = newValue;
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "asdasd";
            //s.Change("Merhaba");
            var Ogrenciler = Class1.OgrencileriGetir();

            var OgrenciIsimleri = from Ogrenci in Ogrenciler
                                  select Ogrenci.Adi;

            string[] OgrenciIsimleriDizisi = OgrenciIsimleri.ToArray();

            Console.WriteLine("Öğrenci isimleri dizisinin elemanları :");

            foreach (string Isim in OgrenciIsimleriDizisi)
            {
                Console.WriteLine(Isim);
            }
            Console.ReadLine();

            //var Ogrenciler =Class1. OgrencileriGetir();

            //var OgrenciIsimleri = Ogrenciler.Select(Ogrenci => Ogrenci.Adi);

            //string[] OgrenciIsimleriDizisi = OgrenciIsimleri.ToArray();

            //Console.WriteLine("Öğrenci isimleri dizisinin elemanları :");

            //foreach (string Isim in OgrenciIsimleriDizisi)
            //{
            //    Console.WriteLine(Isim);
            //}
            //Console.ReadLine();

        }
    }
}
