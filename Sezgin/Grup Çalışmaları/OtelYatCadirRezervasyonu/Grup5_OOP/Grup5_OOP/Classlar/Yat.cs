using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup5_OOP.Classlar
{
    class Yat : Rezervasyon
    {
        public override string KiralananYerTipi()
        {
            return "yat";
        }

        public override string UygulamaAdi()
        {
            return "Yat Yeri Rezervasyonu";
        }

        public override bool YanYanaIkiYerBirdenRezervasyonYapabilirMi()
        {
            return true;
        }
    }
}
