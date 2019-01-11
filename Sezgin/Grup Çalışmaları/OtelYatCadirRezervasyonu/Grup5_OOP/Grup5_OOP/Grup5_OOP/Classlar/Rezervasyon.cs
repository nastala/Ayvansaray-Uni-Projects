using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup5_OOP.Classlar
{
    abstract class Rezervasyon
    {
        private static DateTime _currentDate = DateTime.Today;
        protected const int odaSayisi = 10;
        protected const int gunSayisi = 30;
        protected Random r;
        protected RezervasyonEnum[,] rezervasyonDurumu = new RezervasyonEnum[odaSayisi, gunSayisi];
        protected enum RezervasyonEnum
        {
            Bos = 0,
            Dolu = 1,
            Temizlik = 2
        }

        public Rezervasyon()
        {

        }

        public Rezervasyon(Random random)
        {
            r = random;
        }

        public abstract string UygulamaAdi();
        public abstract string KiralananYerTipi();
        public abstract bool YanYanaIkiYerBirdenRezervasyonYapabilirMi();
        public abstract int Fiyat(int gun, bool ciftYer);

        public void RasgeleDoldur()
        {
            int rGun, rOda, rDurum;
            int i = 0;
            string kiralanan = KiralananYerTipi();

            #region while
            while (i < 50)
            {
                rGun = r.Next(0, gunSayisi);
                rOda = r.Next(0, odaSayisi);
                rDurum = r.Next(0, 2);
                if (rezervasyonDurumu[rOda, rGun] == 0)
                {
                    if (rDurum == 1)
                    {
                        if (rGun != gunSayisi - 1)
                        {
                            if (rezervasyonDurumu[rOda, rGun + 1] == RezervasyonEnum.Bos)
                            {
                                rezervasyonDurumu[rOda, rGun] = RezervasyonEnum.Dolu;
                                if(!kiralanan.Equals("yat"))
                                    rezervasyonDurumu[rOda, rGun + 1] = RezervasyonEnum.Temizlik;
                                i++;
                            }
                        }
                        else
                        {
                            rezervasyonDurumu[rOda, rGun] = RezervasyonEnum.Dolu;
                            i++;
                        }
                    }
                    else
                    {
                        rezervasyonDurumu[rOda, rGun] = (RezervasyonEnum)rDurum;
                        i++;
                    }
                }
            }
            #endregion

            //rezervasyonDurumu[0, 0] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[0, 1] = RezervasyonEnum.Temizlik;
            //rezervasyonDurumu[0, 5] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[0, 6] = RezervasyonEnum.Temizlik;
            //rezervasyonDurumu[1, 7] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[1, 8] = RezervasyonEnum.Temizlik;
            //rezervasyonDurumu[2, 9] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[2, 10] = RezervasyonEnum.Temizlik;
            //rezervasyonDurumu[5, 15] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[5, 16] = RezervasyonEnum.Temizlik;
            //rezervasyonDurumu[8, 20] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[8, 21] = RezervasyonEnum.Temizlik;
            //rezervasyonDurumu[0, 27] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[0, 28] = RezervasyonEnum.Temizlik;
            //rezervasyonDurumu[9, 29] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[4, 0] = RezervasyonEnum.Temizlik;
            //rezervasyonDurumu[5, 1] = RezervasyonEnum.Dolu;
            //rezervasyonDurumu[5, 2] = RezervasyonEnum.Temizlik;
        }

        protected virtual int BugunIcinTekYerlikBosOda() { return -1; }

        protected virtual int BugunIcinCiftYerlikBosOda() { return -1; }

        public void BugunIcinTekYerlikOtelVeYatYeriRezervasyonu(Rezervasyon[] mixRezervasyon)
        {
            int otelOda = mixRezervasyon[0].BugunIcinTekYerlikBosOda();
            int yatOda = mixRezervasyon[1].BugunIcinTekYerlikBosOda();
            if (otelOda != -1 && yatOda != -1)
            {
                mixRezervasyon[0].rezervasyonDurumu[otelOda, 0] = RezervasyonEnum.Dolu;
                mixRezervasyon[0].rezervasyonDurumu[otelOda, 1] = RezervasyonEnum.Temizlik;
                mixRezervasyon[1].rezervasyonDurumu[yatOda, 0] = RezervasyonEnum.Dolu;
                Console.WriteLine(string.Format("\n{0} {1:00} sizin için ayrıldı <butik otel>", mixRezervasyon[0].KiralananYerTipi(), otelOda + 1));
                Console.WriteLine(string.Format("\n{0} {1:00} sizin için ayrıldı <yat>", mixRezervasyon[1].KiralananYerTipi(), yatOda + 1));
            }
            else
            {
                Console.WriteLine("Bugün için tek yerlik boş yerimiz kalmadı");
            }
        }

        public void BugunIcinCiftYerlikOtelVeYatYeriRezervasyonu(Rezervasyon[] mixRezervasyon)
        {
            int otelOda = mixRezervasyon[0].BugunIcinTekYerlikBosOda();
            int yatOda = mixRezervasyon[1].BugunIcinCiftYerlikBosOda();
            if (otelOda != -1 && yatOda != -1)
            {
                mixRezervasyon[0].rezervasyonDurumu[otelOda, 0] = RezervasyonEnum.Dolu;
                mixRezervasyon[0].rezervasyonDurumu[otelOda, 1] = RezervasyonEnum.Temizlik;
                mixRezervasyon[1].rezervasyonDurumu[yatOda, 0] = RezervasyonEnum.Dolu;
                mixRezervasyon[1].rezervasyonDurumu[yatOda + 1, 0] = RezervasyonEnum.Dolu;
                Console.WriteLine(string.Format("\n{0} {1:00} sizin için ayrıldı <butik otel>", mixRezervasyon[0].KiralananYerTipi(), otelOda + 1));
                Console.WriteLine(string.Format("\n{0} {1:00} sizin için ayrıldı <yat>", mixRezervasyon[1].KiralananYerTipi(), yatOda + 1));
            }
            else
            {
                Console.WriteLine("Bugün için tek yerlik boş yerimiz kalmadı");
            }
        }

        public void YatVeOtelRezervasyonu(DateTime dBaslangic, DateTime dBitis, Rezervasyon[] mixRezervasyon, bool yanYanaIkiYer = false)
        {

        }

        public void BugunkuBosOdalar()
        {
            string kiralanan = KiralananYerTipi();
            bool bosOdaYok = true;
            for (int i = 0; i < odaSayisi; i++)
            {
                if (rezervasyonDurumu[i, 0] == RezervasyonEnum.Bos
                    && rezervasyonDurumu[i, 1] == RezervasyonEnum.Bos)
                {
                    bosOdaYok = false;
                    Console.WriteLine(string.Format("{0} {1:00}", kiralanan, i + 1));
                }
            }
            if (bosOdaYok)
                Console.WriteLine("Bugun icin bos " + kiralanan + " yok");
        }

        public void RezervasyonYap() 
        {
            RezervasyonYap(DateTime.Today, DateTime.Today);
        }

        public void RezervasyonYap(DateTime dBaslangic, DateTime dBitis, bool YanYanaIkiYer = false)
        {
            if (dBaslangic < DateTime.Today)
            {
                Console.WriteLine("Baslangic tarih bugunden kucuk olamaz");
                return;
            }
            if (dBitis < dBaslangic)
            {
                Console.WriteLine("Bitis tarihi baslangic tarihinden kucuk olamaz");
                return;
            }
            if ((dBaslangic - DateTime.Today).Days >= gunSayisi)
            {
                Console.WriteLine("Baslangic tarihi {0:dd/MM/yyyy} tarihinden buyuk olamaz", DateTime.Today.AddDays(gunSayisi - 1));
                return;
            }
            if ((dBitis - DateTime.Today).Days >= gunSayisi)
            {
                Console.WriteLine("Bitis tarihi {0:dd/MM/yyyy} tarihinden buyuk olamaz", DateTime.Today.AddDays(gunSayisi - 1));
                return;
            }
            int gun1 = (dBaslangic - DateTime.Today).Days;
            int gun2 = (dBitis - DateTime.Today).Days;
            bool bosOdaYok = true;
            string kiralanan = KiralananYerTipi();
            for (int i = 0; YanYanaIkiYer ? i < odaSayisi - 1 : i < odaSayisi; i++)
            {
                bool odaMusait = true;
                for (int j = gun1; j <= gun2; j++)
                {
                    if (rezervasyonDurumu[i, j] != RezervasyonEnum.Bos)
                    {
                        odaMusait = false;
                        break;
                    }

                    if (YanYanaIkiYer && rezervasyonDurumu[i + 1, j] != RezervasyonEnum.Bos)
                    {
                        odaMusait = false;
                        break;
                    }
                }
                if (!(kiralanan.Equals("yat")) && (gun2 + 1) < gunSayisi)
                {
                    if (rezervasyonDurumu[i, gun2 + 1] != RezervasyonEnum.Bos)
                        odaMusait = false;
                    if (YanYanaIkiYer && rezervasyonDurumu[i + 1, gun2 + 1] != RezervasyonEnum.Bos)
                        odaMusait = false;
                }
                if (odaMusait)
                {
                    bosOdaYok = false;
                    for (int j = gun1; j <= gun2; j++)
                    {
                        rezervasyonDurumu[i, j] = RezervasyonEnum.Dolu;
                        if (YanYanaIkiYer)
                            rezervasyonDurumu[i + 1, j] = RezervasyonEnum.Dolu;
                    }
                    if (!kiralanan.Equals("yat"))
                    {
                        if((gun2 + 1) < gunSayisi)
                        {
                            rezervasyonDurumu[i, gun2 + 1] = RezervasyonEnum.Temizlik;
                            if(YanYanaIkiYer)
                                rezervasyonDurumu[i + 1, gun2 + 1] = RezervasyonEnum.Temizlik;
                        }
                    }
                    Console.WriteLine("{0} numarali " + kiralanan + " sizin icin ayrildi", i + 1);
                    Console.WriteLine("Toplam fiyat : {1} TL, {0} gun.",
                        (gun2 - gun1) + 1,
                        this.Fiyat((gun2 - gun1) + 1, YanYanaIkiYer));
                    break;
                }
            }
            if (bosOdaYok)
                Console.WriteLine("Istediginiz tarihte bos " + kiralanan + " yok");
        }

        public void RezervasyonYap(DateTime dBaslangic, int gun, bool YanYanaIkiYer = false)
        {
            RezervasyonYap(dBaslangic, dBaslangic.AddDays(gun), YanYanaIkiYer);
        }

        static void TarihCetveliniYazdir(string onKisim)
        {
            Console.Write(onKisim);
            for (int j = 0; j < gunSayisi; j++)
            {
                Console.Write(" {0:00}", _currentDate.AddDays(j).Day);
            }
            Console.WriteLine();
        }

        public void AylikDolulukDurumu()
        {
            string onKisim = "";
            string kiralanan = KiralananYerTipi();
            for (int i = 0; i < (3 + kiralanan.Length); i++)
                onKisim += " ";

            TarihCetveliniYazdir(onKisim);

            for (int i = 0; i < odaSayisi; i++)
            {
                Console.Write(kiralanan + " {0:00}", i + 1); 
                for (int j = 0; j < gunSayisi; j++)
                {
                    if (rezervasyonDurumu[i, j] == RezervasyonEnum.Bos)
                        Console.Write(" - ");
                    else if (rezervasyonDurumu[i, j] == RezervasyonEnum.Dolu)
                        Console.Write(" D ");
                    else
                        Console.Write(" x ");
                }
                Console.WriteLine();
            }
        }

        public void GunSonuIslemi()
        {
            string kiralanan = KiralananYerTipi();
            for (int i = 0; i < odaSayisi; i++)
            {
                for (int j = 0; j < gunSayisi - 1; j++)
                {
                    rezervasyonDurumu[i, j] = rezervasyonDurumu[i, j + 1];
                }
                if (rezervasyonDurumu[i, gunSayisi - 2] == RezervasyonEnum.Dolu && !kiralanan.Equals("yat"))
                    rezervasyonDurumu[i, gunSayisi - 1] = RezervasyonEnum.Temizlik;
                else
                    rezervasyonDurumu[i, gunSayisi - 1] = RezervasyonEnum.Bos;
            }
            _currentDate = _currentDate.AddDays(1);
        }

        public void GunBazindaDolulukOranlari()
        {
            TarihCetveliniYazdir(" -------- ");
            Console.Write("Doluluk % ");
            int doluOdaSayisi = 0;

            for (int j = 0; j < gunSayisi; j++)
            {
                doluOdaSayisi = 0;
                for (int i = 0; i < odaSayisi; i++)
                {
                    if (rezervasyonDurumu[i, j] == RezervasyonEnum.Dolu)
                    {
                        doluOdaSayisi++;
                    }
                }
                Console.Write("{0,3}", (int)(100f * doluOdaSayisi / odaSayisi));
            }
            Console.WriteLine();
        }
    }
}
