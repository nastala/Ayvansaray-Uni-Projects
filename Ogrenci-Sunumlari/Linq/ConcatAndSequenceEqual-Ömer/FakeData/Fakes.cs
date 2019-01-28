using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData
{
    public class Fakes
    {
        public class Kayit
        {
            public int No { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Grade { get; set; }
            public string Sex { get; set; }
            public DateTime DogumTarihi { get; set; }
            public int Yasi { get; set; }
            public int Kulup { get; set; }
            public int[] Notlar { get; set; }
            public double Ortalama { get; set; }
            public bool Basarili { get; set; }
            public int OkunanKitapSayisi { get; set; }
        }

        // Kulup kaydı olarak kullanılan sınıf...
        public class KulupKaydi
        {
            public int KayitNo { get; set; }
            public string Adi { get; set; }
            public string Sorumlu { get; set; }
        }

        // Öğrenci kaydı tutan Kayit isimli sınıfın bir listesini döndüren yöntem...
        public static List<Kayit> GetStudents()
        {
            List<Kayit> Ogrenciler = new List<Kayit>();
            Ogrenciler.Add(new Kayit()
            {
                No = 2,
                Name = "Tuncay",
                LastName = "Çağrı",
                Sex = "Male",
                DogumTarihi = new DateTime(2002, 2, 27),
                Grade = 4,
                Kulup = 0,
                OkunanKitapSayisi = 11,
                Notlar = new int[] { 75, 70, 75 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 4,
                Name = "Jale",
                LastName = "İkinci",
                Sex = "Female",
                DogumTarihi = new DateTime(1970, 1, 28),
                Grade = 3,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 100, 95, 97, 96 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 7,
                Name = "Tekin",
                LastName = "Uğurlu",
                Sex = "Male",
                DogumTarihi = new DateTime(1955, 3, 26),
                Grade = 1,
                Kulup = 1,
                OkunanKitapSayisi = 4,
                Notlar = new int[] { 30, 40, 20 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 8,
                Name = "Mesut",
                LastName = "Bahtiyar",
                Sex = "Male",
                DogumTarihi = new DateTime(1980, 4, 25),
                Grade = 4,
                Kulup = 1,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 70, 10, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 12,
                Name = "Veli",
                LastName = "Canlı",
                Sex = "Male",
                DogumTarihi = new DateTime(1993, 5, 24),
                Grade = 4,
                Kulup = 2,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 80, 40, 10 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 6,
                Name = "Ahmet",
                LastName = "Geçe",
                Sex = "Male",
                DogumTarihi = new DateTime(1958, 6, 23),
                Grade = 2,
                Kulup = 2,
                OkunanKitapSayisi = 9,
                Notlar = new int[] { 70, 80, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 15,
                Name = "Fatma",
                LastName = "Teyze",
                Sex = "Female",
                DogumTarihi = new DateTime(1972, 7, 22),
                Grade = 3,
                Kulup = 1,
                OkunanKitapSayisi = 12,
                Notlar = new int[] { 70, 98, 97, 92 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 14,
                Name = "Mehmet",
                LastName = "Emre",
                Sex = "Male",
                DogumTarihi = new DateTime(1970, 8, 21),
                Grade = 4,
                Kulup = 0,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 80, 22, 97 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 3,
                Name = "Hale",
                LastName = "Birinci",
                Sex = "Female",
                DogumTarihi = new DateTime(1982, 9, 20),
                Grade = 2,
                Kulup = 1,
                OkunanKitapSayisi = 11,
                Notlar = new int[] { 20, 40, 10, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 13,
                Name = "Ayşe",
                LastName = "Hanım",
                Sex = "Female",
                DogumTarihi = new DateTime(1983, 10, 19),
                Grade = 2,
                Kulup = 1,
                OkunanKitapSayisi = 5,
                Notlar = new int[] { 100, 40, 100 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 11,
                Name = "Cevdet",
                LastName = "Döğer",
                Sex = "Male",
                DogumTarihi = new DateTime(1967, 11, 18),
                Grade = 3,
                Kulup = 2,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 20, 0, 30, 15 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 1,
                Name = "Nuri",
                LastName = "Babayiğit",
                Sex = "Male",
                DogumTarihi = new DateTime(1998, 12, 17),
                Grade = 2,
                Kulup = 2,
                OkunanKitapSayisi = 6,
                Notlar = new int[] { 55, 75, 65 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 5,
                Name = "Kenan",
                LastName = "Oran",
                Sex = "Male",
                DogumTarihi = new DateTime(1961, 1, 16),
                Grade = 1,
                Kulup = 0,
                OkunanKitapSayisi = 9,
                Notlar = new int[] { 50, 70, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 9,
                Name = "Lale",
                LastName = "Üçüncü",
                Sex = "Female",
                DogumTarihi = new DateTime(1990, 2, 15),
                Grade = 3,
                Kulup = 0,
                OkunanKitapSayisi = 6,
                Notlar = new int[] { 20, 0, 30 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 10,
                Name = "Erhan",
                LastName = "Erkanlı",
                Sex = "Male",
                DogumTarihi = new DateTime(1958, 3, 14),
                Grade = 1,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 90, 90, 90, 90 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 16,
                Name = "Erhan",
                LastName = "Fidan",
                Sex = "Male",
                DogumTarihi = new DateTime(1968, 4, 13),
                Grade = 2,
                Kulup = 1,
                OkunanKitapSayisi = 8,
                Notlar = new int[] { 95, 70, 100, 80 }
            });
            Ogrenciler.Add(new Kayit()
            {
                No = 17,
                Name = "Erhan",
                LastName = "Çelik",
                Sex = "Male",
                DogumTarihi = new DateTime(1978, 5, 12),
                Grade = 3,
                Kulup = 1,
                OkunanKitapSayisi = 7,
                Notlar = new int[] { 90, 55, 90 }
            });

            foreach (var Ogrenci in Ogrenciler)
            {
                Ogrenci.Ortalama = Ogrenci.Notlar.Average();
                Ogrenci.Basarili = Ogrenci.Ortalama >= 55;
                Ogrenci.Yasi = DateTime.Now.Year - Ogrenci.DogumTarihi.Year;
            }

            return Ogrenciler;

        }

        // Kulüp kaydı tutan KulupKaydi isimli sınıfın bir listesini döndüren yöntem.
        private static List<KulupKaydi> KulupleriGetir()
        {
            List<KulupKaydi> Kulupler = new List<KulupKaydi>();
            Kulupler.Add(new KulupKaydi() { KayitNo = 0, Adi = "Gezi", Sorumlu = "Tanju Bülbül" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 1, Adi = "Tiyatro", Sorumlu = "Metin Öztürk" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 2, Adi = "Müzik", Sorumlu = "Nuri Sezer" });
            Kulupler.Add(new KulupKaydi() { KayitNo = 3, Adi = "Kitap", Sorumlu = "Kazım Ünlüol" });
            return Kulupler;
        }
    }
}
