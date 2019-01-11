using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup5_OOP.Classlar
{
    class Cadir : Rezervasyon
    {
        public Cadir()
        {

        }

        public Cadir(Random random) : base(random)
        {
        }

        public override string KiralananYerTipi()
        {
            return "çadır";
        }

        public override int Fiyat(int gun, bool ciftYer)
        {
            return gun * (ciftYer ? 160 : 100);
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
