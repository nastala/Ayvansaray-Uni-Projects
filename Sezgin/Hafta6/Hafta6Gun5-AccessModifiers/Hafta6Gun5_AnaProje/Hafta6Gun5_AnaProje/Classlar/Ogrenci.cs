using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Gun5_AnaProje.Classlar
{
    class Ogrenci : Kisi
    {
        int ogrNo;

        public Ogrenci()
        {
            this.TCKimlik = 123124;
            this.ogrNo = 1234;
        }

        protected override int maasHesapla(int a, int b)
        {
            return a * b;
        }
    }
}
