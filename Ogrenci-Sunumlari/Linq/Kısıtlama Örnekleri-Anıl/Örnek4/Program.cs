using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek4
{
    class Program
    {
        // Öğrenci kaydı olarak kullanılan sınıf...
        public class Kayit
        {
            public int No { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public int Sinif { get; set; }
            public string Cinsiyet { get; set; }
            public DateTime DogumTarihi { get; set; }
            public int Yasi { get; set; }
            public int Kulup { get; set; }
            public int[] Notlar { get; set; }
            public double Ortalama { get; set; }
            public bool Basarili { get; set; }
            public int OkunanKitapSayisi { get; set; }
        }
        // Öğrenci kaydı tutan Kayit isimli sınıfın bir listesini döndüren yöntem...
        private static List<Kayit> OgrencileriGetir()
        {
            List<Kayit> Ogrenciler = new List<Kayit>();
            Ogrenciler.Add(new Kayit()
            {
                No = 2,
                Adi = "Tuncay",
                Soyadi = "Çağrı",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(2002, 2, 27),
                Sinif = 4,
                Kulup = 0,
                OkunanKitapSayisi = 11,
                Notlar = new int[] { 75, 70, 75 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 4,
                Adi = "Jale",
                Soyadi = "İkinci",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1970, 1, 28),
                Sinif = 3,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 100, 95, 97, 96 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 7,
                Adi = "Tekin",
                Soyadi = "Uğurlu",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1955, 3, 26),
                Sinif = 1,
                Kulup = 1,
                OkunanKitapSayisi = 4,
                Notlar = new int[] { 30, 40, 20 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 8,
                Adi = "Mesut",
                Soyadi = "Bahtiyar",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1980, 4, 25),
                Sinif = 4,
                Kulup = 1,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 70, 10, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 12,
                Adi = "Veli",
                Soyadi = "Canlı",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1993, 5, 24),
                Sinif = 4,
                Kulup = 2,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 80, 40, 10 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 6,
                Adi = "Ahmet",
                Soyadi = "Geçe",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1958, 6, 23),
                Sinif = 2,
                Kulup = 2,
                OkunanKitapSayisi = 9,
                Notlar = new int[] { 70, 80, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 15,
                Adi = "Fatma",
                Soyadi = "Teyze",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1972, 7, 22),
                Sinif = 3,
                Kulup = 1,
                OkunanKitapSayisi = 12,
                Notlar = new int[] { 70, 98, 97, 92 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 14,
                Adi = "Mehmet",
                Soyadi = "Emre",
                Cinsiyet = "Erkek",
                DogumTarihi = new DateTime(1970, 8, 21),
                Sinif = 4,
                Kulup = 0,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 80, 22, 97 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 3,
                Adi = "Hale",
                Soyadi = "Birinci",
                Cinsiyet = "Bayan",
                DogumTarihi = new DateTime(1982, 9, 20),
                Sinif = 2,
                Kulup = 1,
                OkunanKitapSayisi = 11,
                Notlar = new int[] { 20, 40, 10, 30 }
            });
            //foreach döngüsü içerisinde ogrenciler listesindeki ogrencilerin not ortalamasını aldık.
            //Ogrenci not ortalaması 55'e eşit ve büyük olan ogrencilerin yaşını gösterdik.
            foreach (var Ogrenci in Ogrenciler)
            {
                Ogrenci.Ortalama = Ogrenci.Notlar.Average();
                Ogrenci.Basarili = Ogrenci.Ortalama >= 55;
                Ogrenci.Yasi = DateTime.Now.Year - Ogrenci.DogumTarihi.Year;
            }

            return Ogrenciler;

        }

        static void Main(string[] args)
        {
            //başarılı öğrencileri seçer ve öğrenci kaydında yer alan notlar isimli bir dizinin elemanlarını da kullanarak 
            //başarılı öğrencileri ve ikinci bir foreach aracılığıyla öğrenci notlarını da çıktıya yazar.
            var Ogrenciler = OgrencileriGetir();
            var BasariliOgrenciler = from Ogrenci in Ogrenciler
                                     where Ogrenci.Basarili
                                     select Ogrenci;
            Console.WriteLine("Başarılı öğrencilerin notları...");
            foreach (var Ogrenci in BasariliOgrenciler)
            {
                Console.WriteLine("{0}, {1}", Ogrenci.Soyadi, Ogrenci.Adi);
                foreach (var Notu in Ogrenci.Notlar)
                {
                    Console.Write("{0} ", Notu);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //var Ogrenciler = OgrencileriGetir();

            //var BasariliOgrenciler = Ogrenciler.Where(Ogrenci => Ogrenci.Basarili);
            //Console.WriteLine("Başarılı öğrencilerin notları...");
            //foreach (var Ogrenci in BasariliOgrenciler)
            //{
            //    Console.WriteLine("{0}, {1}", Ogrenci.Soyadi, Ogrenci.Adi);
            //    foreach (var Notu in Ogrenci.Notlar)
            //    {
            //        Console.Write("{0} ", Notu);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }
    }
}
