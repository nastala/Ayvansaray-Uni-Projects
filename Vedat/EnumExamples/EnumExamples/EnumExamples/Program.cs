using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yorum Yap:");
            String Yorum = Console.ReadLine();
            OnayDurum OnayDurumYorum = OnayDurum.OnayBekliyor;
            YorumYap(Yorum, OnayDurumYorum);
            Console.ReadKey();
        }
        enum OnayDurum
        {
            OnayBekliyor = 0,
            Onaylandi = 1,
            Reddedildi = 2
        }
        enum TrueFalse
        {
            enumTrue = 1,
            enumFalse = 2
        }
        static void YorumYap(string Yorum, OnayDurum durum)
        {
            if (durum == OnayDurum.OnayBekliyor)
            {
                Console.WriteLine("Onay Bekleyen Yorum Var:");
                Console.WriteLine(Yorum);
                Console.WriteLine("'Onaylamak İçin 1 Reddetmek için 2:'");
                TrueFalse secim = (TrueFalse)(Convert.ToInt32(Console.ReadLine()));
                if (secim == TrueFalse.enumTrue)
                {
                    OnayDurum OnayDurumYorum = OnayDurum.Onaylandi;
                    YorumYap(Yorum, OnayDurumYorum);
                }
                if (secim == TrueFalse.enumFalse)
                {
                    OnayDurum OnayDurumYorum = OnayDurum.Reddedildi;
                    YorumYap(Yorum, OnayDurumYorum);
                }

            }
            else if (durum == OnayDurum.Onaylandi)
            {
                Console.WriteLine("Onaylanan Yorum:");
                Console.Write(Yorum);
            }
            else if (durum == OnayDurum.Reddedildi)
            {
                Console.WriteLine("Reddedilen Yorum:");
                Console.Write(Yorum);
            }
        }

    }
}
