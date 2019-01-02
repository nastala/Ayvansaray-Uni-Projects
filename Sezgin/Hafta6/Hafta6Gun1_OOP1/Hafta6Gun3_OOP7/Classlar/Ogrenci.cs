using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Gun3_OOP7.Classlar
{
    class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Maas { get; set; }

        public Ogrenci(int id, string ad, string soyad, int maas)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            Maas = maas;
        }

        public Ogrenci()
        {

        }
    }
}
