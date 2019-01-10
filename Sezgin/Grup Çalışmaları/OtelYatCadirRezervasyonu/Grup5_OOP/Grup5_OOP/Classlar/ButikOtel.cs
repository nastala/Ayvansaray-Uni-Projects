using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup5_OOP.Classlar
{
    class ButikOtel : Rezervasyon
    {
        public override string KiralananYerTipi()
        {
            return "oda";
        }

        public override string UygulamaAdi()
        {
            return "Butik Otel Rezervasyonu";
        }

        public override bool YanYanaIkiYerBirdenRezervasyonYapabilirMi()
        {
            return false;
        }
    }
}
