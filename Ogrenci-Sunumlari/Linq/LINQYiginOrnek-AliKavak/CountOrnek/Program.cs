using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqOrnekleri_VeriKaynagi;
namespace CountOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Ogrenciler = Class1.OgrencileriGetir(); // Static method

            var OgrenciSayisi = Ogrenciler.Count();

            Console.WriteLine("Tüm sınıflardaki öğrenci sayıları toplamı {0}.", OgrenciSayisi);

            

            var BasariliOgrenciSayisi = Ogrenciler.Count(Ogrenci => Ogrenci.Basarili);

            Console.WriteLine("Tüm sınıflardaki başarılı öğrenci sayıları toplamı {0}.", BasariliOgrenciSayisi);
            Console.ReadLine();
        }
    }
}
