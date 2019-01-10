using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup5_OOP.Classlar
{
    class Cadir : Rezervasyon
    {
        public override string KiralananYerTipi()
        {
            return "çadır";
        }

        public override string UygulamaAdi()
        {
            return "Çadır Yeri Rezervasyonu";
        }

        public override bool YanYanaIkiYerBirdenRezervasyonYapabilirMi()
        {
            return true;
        }
    }
}
