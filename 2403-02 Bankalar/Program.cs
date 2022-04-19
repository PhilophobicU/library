using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2403_02
{
    class Program
    {
        static void Limited2(double lim)
        {
            double faiz = lim * 0.15;
            double masraf = lim * 0.075;
            double ödeme = lim + masraf + faiz;
            double aylık = ödeme / 72;
            Console.WriteLine("Ödemeniz gereken toplam tutar = " + ödeme);
            Console.WriteLine("Aylık Ödemesi = " + aylık);

        }
        static double Limited1(double lim)
        {
            double faiz = lim * 0.10;
            double masraf = lim * 0.03;
            double ödeme = lim + masraf + faiz;
            return ödeme;

        }
        static bool GeriDon()
        {
            Console.WriteLine("İşleme devam etmek ister misiniz? <e/h>");
            char cevap = Convert.ToChar(Console.ReadLine());

            if (cevap == 'e' || cevap == 'E')
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        static double YirmiFaiz(double anapara1, double anapara2)
        {
            anapara1 += anapara1 * 0.2;
            anapara2 += anapara2 * 0.2;

            double top = (anapara1 + anapara2) / 20;
            return top;
        }
        static double OnFaiz(double anapara1, double anapara2, double anapara3)
        {
            anapara1 += anapara1 * 0.1;
            anapara2 += anapara2 * 0.1;
            anapara3 += anapara3 * 0.1;
            double top = (anapara1 + anapara2 + anapara3) / 8;
            return top;
        }
        static void GarantiBireysel()
        {
        git:
            Console.Clear();
            Console.WriteLine("Bireysel Müşteriyi seçtiniz");
            Console.WriteLine("Kredi Seçeneklerimiz");
            Console.WriteLine("(1)  %10 faiz ile 3 kredi 8 ay vade");
            Console.WriteLine("(2)  %20 faiz ile 2 kredi 20 ay vade");

            int secim2 = Convert.ToInt32(Console.ReadLine());

            if (secim2 == 1)
            {
                Console.WriteLine("Lütfen ana para miktarlarınızı giriniz.");
                Console.WriteLine("1. Kredi Miktarı");
                double anapara1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2. Kredi Miktarı");
                double anapara2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("3. Kredi Miktarı");
                double anapara3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("8 Ay boyunca Aylık ödemeniz = " + OnFaiz(anapara1, anapara2, anapara3));
                if (GeriDon() == true)
                {
                    Banks();
                }
                else
                {
                    Console.WriteLine("İşleminiz tamamlanmıştır.Değerli vaktiniz için teşekkürler.");
                    Console.ReadLine();
                }

            }
            else if (secim2 == 2)
            {
                Console.WriteLine("1. Kredi Miktarı");
                double anapara1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2. Kredi Miktarı");
                double anapara2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("20 Ay Boyunca Aylık Ödemeniz = " + YirmiFaiz(anapara1, anapara2));

                if (GeriDon() == true)
                {
                    Banks();
                }
                else
                {
                    Console.WriteLine("İşleminiz tamamlanmıştır.Değerli vaktiniz için teşekkürler.");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız lütfen tekrar deneyiniz");
                Console.Clear();
                goto git;
            }
        }
        static void GarantiKurumsal()
        {
            string admin;
            string sifre;
            do
            {
                Console.WriteLine("Lütfen Bankamızın sizin için oluşturduğu Kullanici adi ve şifrenizi giriniz");
                Console.WriteLine();
                Console.Write("Kullanıcı adi : ");
                admin = Console.ReadLine();
                Console.Write("Şifre : ");
                sifre = Console.ReadLine();

            }
            while (admin != "admin" || sifre != "sifre");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Teşekkürler Başarıyla Giriş yaptınız");

            Console.WriteLine();
            FaaliyetAlani();

        }
        private static void FaaliyetAlani()
        {
            Console.Write("Faaliyet alanınızı giriniz : ");
            Console.WriteLine();
            Console.WriteLine("1- Hizmet Sektörü");
            Console.WriteLine("2- Sanayi ");
            Console.WriteLine("3- Bla");
            Console.WriteLine("4- X");

            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1 || secim == 2)
            {
                Console.WriteLine("Şirket Tipiniz.");
                Console.WriteLine();
                Console.WriteLine("1- Limited");
                Console.WriteLine("2- Anonim");
                Console.WriteLine();
                int tip = Convert.ToInt32(Console.ReadLine());

                if (tip == 1)
                {
                    Limited();
                }
                else if (tip == 2)
                {
                    Anonim();
                }
                else
                {

                }


            }
        }
        private static void Limited()
        {
            Console.WriteLine("Limited seçimi yaptınız.");
            Console.WriteLine();
            Console.WriteLine("Lütfen istediğiniz krediyi giriniz.");
            double lim = Convert.ToDouble(Console.ReadLine());
            if (lim < 50000)
            {
                Console.WriteLine("68 Ayda ödiyeceğiniz tutar : " + Limited1(lim));
            }
            else if (lim > 50000 && lim < 100000)
            {
                Limited2(lim);
            }
            else if (lim > 100000)
            {
                Console.WriteLine("Eni vici vokke");
            }

        }
        private static void Anonim()
        {
            Console.WriteLine("Anonim seçimini yaptınız");
        }
        static void Garanti()
        {
        git:
            Console.Clear();
            Console.WriteLine("Garanti bankasına hoş geldiniz.");
            Console.WriteLine("1- Bireysel Müşteri");
            Console.WriteLine("2- Kurumsal Müşteri");

            int secim1 = Convert.ToInt32(Console.ReadLine());

            if (secim1 == 1)
            {
                GarantiBireysel();
            }
            else if (secim1 == 2)
            {
                GarantiKurumsal();
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız. Lütfen tekrar seçim yapınız");
                goto git;
            }

        }
        static void Ziraat()
        {
        git:
            Console.Clear();
            Console.WriteLine("Ziraat bankasına hoş geldiniz.");
            Console.WriteLine("1- İhtiyaç Kredisi");
            Console.WriteLine("2- Konut Kredisi");

            int secim1 = Convert.ToInt32(Console.ReadLine());

            if (secim1 == 1)
            {
                Ihtiyackredisi();
            }
            else if (secim1 == 2)
            {
                Konutkredisi();
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız. Lütfen tekrar seçim yapınız");
                goto git;
            }

        }
        private static void Konutkredisi()
        {
            Console.WriteLine("Konut kredisini seçtiniz.");
            Console.WriteLine();
            Console.WriteLine("1- 0. El Daire");
            Console.WriteLine("2- 2. El Daire");

            int daire = Convert.ToInt32(Console.ReadLine());

            if (daire == 1 || daire == 2)
            {
                Ilceler();
            }
            else
            {
                Console.Write("(15 Ay) Lütfen çekmek istediğiniz kredi miktarını belirtiniz : ");
                float cekim = Convert.ToSingle(Console.ReadLine());
                float aylik = cekim / 15;

                float tp = 0;
                for (int i = 1; i < 16; i++)
                {
                    aylik += aylik * 1.02f;
                    Console.WriteLine("Aylık ödemeleriniz : " + aylik);
                    tp += aylik;
                }
                Console.WriteLine("toplam ödemeniz : " + tp);

            }

        }

        private static void Ilceler()
        {
            Console.Write("Lütfen çekmek istediğiniz kredi miktarını belirtiniz : ");
            float cekim = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lütfen İlçe Seçimi Yapınız.");
            Console.WriteLine("1- Kadıköy");
            Console.WriteLine("2- Etiler");
            Console.WriteLine("3-Üsküdar");
            Console.WriteLine("4- Şişli");
            Console.WriteLine("5-Diğerleri");
            Console.WriteLine();
            Console.WriteLine();

            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1 || secim == 2)
            {
                EtilerKadikoy(cekim);
            }
            else if (secim == 3 || secim == 4)
            {
                UskudarSisli(cekim);
            }
            else
            {
                DigerIlceler(cekim);
            }



        }
        static float EtilerKadikoy(float cekim)
        {
            float ödeme;
            ödeme = ((cekim * 1.18f) + 5000 + (cekim * 0.045f));

            return ödeme;
        }
        static float UskudarSisli(float cekim)
        {
            float ödeme;
            ödeme = ((cekim * 1.20f) + 7500 + (cekim * 0.035f));

            return ödeme;
        }
        static float DigerIlceler(float cekim)
        {
            float ödeme;
            ödeme = (cekim * 1.20f);

            return ödeme;
        }

        static void Ihtiyackredisi()
        {
            Console.Write("Ödeme vadenizi giriniz : ");
            double vade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen bankamızdan istediğiniz kredi miktarını giriniz : ");
            double kredi = Convert.ToDouble(Console.ReadLine());

            double aylik = kredi / vade;
            double tp = 0;
            for (int i = 1; i <= vade; i++)
            {
                aylik += aylik * 0.02;
                tp += aylik;
                Console.WriteLine(i + ". ay ödemeniz gereken tutar = " + aylik);
                if (i == 10)
                {
                    Console.WriteLine("Toplam : " + tp);
                }
            }
        }
        static void IsBankasi()
        {
        git:
            Console.Clear();
            Console.WriteLine("İş bankasına hoş geldiniz.");
            Console.WriteLine("1- Bireysel Müşteri");
            Console.WriteLine("2- Kurumsal Müşteri");

            int secim1 = Convert.ToInt32(Console.ReadLine());

            if (secim1 == 1)
            {

            }
            else if (secim1 == 2)
            {

            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız. Lütfen tekrar seçim yapınız");
                goto git;
            }

        }
        static void Banks()
        {
            Console.Clear();
            Console.WriteLine("Uygulamaya hoşgeldiniz. Lütfen bir banka seçimi yapınız");
            Console.WriteLine();
            Console.WriteLine("1- Garanti Bankası");
            Console.WriteLine("2- Ziraat Bankası");
            Console.WriteLine("3- İş Bankası");

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Garanti();
                    break;
                case 2:
                    Ziraat();
                    break;
                case 3:
                    IsBankasi();
                    break;
            }

        }
        static void Main(string[] args)
        {
            Banks();
            Console.ReadLine();




            // banka seçiniz
            // ana sayfa adında voidli metot
            // menü switch olacak
            //garanti bankası               1 garanti bankası ise     (1) bireysel müşteri (2) kurumsal müşteri  if 
            //Ziraat Bankası                                          kaç faiz istediğini sor      bireysel müşteri ise a)% 10 faiz ile 3 tane kredi 8 ay vade(returnlu anaparyı al retrunlü faiz) 3 anapara iste 10 15 7,5  hepsinin %10unu al topla aylık ödemesini bul     b) %20 faiz ile 2 tane kredi 20 ay fade
            //İş bankası


        }
    }
}