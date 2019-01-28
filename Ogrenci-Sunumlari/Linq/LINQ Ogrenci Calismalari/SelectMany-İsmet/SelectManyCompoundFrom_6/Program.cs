using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqVeriKaynagi;

namespace SelectManyCompoundFrom_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler =Class1.OgrencileriGetir();
            List<KulupKaydi> Kulupler =Class1.KulupleriGetir();
            var GenclerinKulupleri =
                     Ogrenciler.SelectMany(Ogrenci =>Kulupler
                     .Where(Kulup =>Kulup.KayitNo == Ogrenci
                     .Kulup && Ogrenci.DogumTarihi >= new DateTime(1990, 1, 1)),
                      (Ogrenci, Kulup) =>new {Ogrenci.Adi,DogumYili = Ogrenci.DogumTarihi.Year,KulupAdi = Kulup.Adi});
            Console.WriteLine("1.1.1990 ve daha sonra doğan öğrencilerin kulupleri :");
            foreach (var Satir in GenclerinKulupleri)
            {
                Console.WriteLine("{0}, {1} kulübüne üye. Doğum yılı {2}.",Satir.Adi, Satir.KulupAdi,Satir.DogumYili);

            }
            Console.ReadLine();
        }
    }
}
