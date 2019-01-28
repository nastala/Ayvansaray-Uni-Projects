using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;

namespace ToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler =Class1. OgrencileriGetir();

           

            var OgrenciNotlariSozlugu = Ogrenciler.ToDictionary(Ogrenci => Ogrenci.No);

            // veya
            // Dictionary OgrenciNotlariSozlugu = OgrenciListesi.ToDictionary(Ogrenci => Ogrenci.No);

            Kayit BirOgrenciKaydi = OgrenciNotlariSozlugu[14];

            Console.WriteLine("14 numaralı öğrencinin bazı bilgileri ...");

            Console.WriteLine("Adı {0} olan bu öğrenci, {1}. sınıfta okumaktadır ve {2} doğumludur.",
                              BirOgrenciKaydi.Adi,
                              BirOgrenciKaydi.Sinif,
                              BirOgrenciKaydi.DogumTarihi.Year);
            Console.ReadLine();
        }
    }
}
