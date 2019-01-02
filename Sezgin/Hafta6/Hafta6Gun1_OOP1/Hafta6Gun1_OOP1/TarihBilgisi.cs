using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Gun1_OOP1
{
    // Class-1
    class TarihBilgisi
    {
        private DateTime tarih;

        public string GecerliTarih
        {
            set { tarih = Convert.ToDateTime(value); }
        }

        public double GunOlarakTarihFarki(DateTime farkAlinacakTarih)
        {
            return (farkAlinacakTarih - tarih).TotalDays;
        }
    }
}
