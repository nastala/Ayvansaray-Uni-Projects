using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_FirmaKayit.Hangar
{
    class Numaralar
    {
        DBFirmaDataContext _db = new DBFirmaDataContext();

        public string FirmaNo()
        {
            try
            {
                var numara = (from item in _db.bgFirmaKayits orderby item.ID descending
                              select item.Firma_No).First();
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return ("0000001");
            }
        }
    }
}
