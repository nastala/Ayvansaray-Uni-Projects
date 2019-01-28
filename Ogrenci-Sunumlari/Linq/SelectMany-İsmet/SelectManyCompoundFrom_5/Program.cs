using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqVeriKaynagi;

namespace SelectManyCompoundFrom_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kayit> Ogrenciler =Class1.OgrencileriGetir();
            List<KulupKaydi> Kulupler =Class1.KulupleriGetir();
            var GenclerinKulupleri = from Ogrenci in Ogrenciler
                                     from Kulup in Kulupler
                                     where Ogrenci.DogumTarihi >= new DateTime(1990, 1, 1) &&
                                           Kulup.KayitNo == Ogrenci.Kulup
                                     select
                                            new
                                            {   Ogrenci.Adi,
                                                DogumYili = Ogrenci.DogumTarihi.Year,
                                                KulupAdi = Kulup.Adi
                                            };
            Console.WriteLine("1.1.1990 ve daha sonra doğan öğrencilerin kulupleri :");
            foreach (var Satir in GenclerinKulupleri)
            {
                Console.WriteLine("{0}, {1} kulübüne üye. Doğum yılı {2}.",
                                  Satir.Adi,
                                  Satir.KulupAdi,
                                  Satir.DogumYili);
            }
            Console.ReadLine();
        }
    }
}
