using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2303_10
{
    class Program
    {
        public static bool devam(bool d)
        {

            Console.WriteLine("İşleme devam etmek ister misiniz ?");
            bool d1 = Convert.ToBoolean(Console.ReadLine());

            if (d1 == true)
            {
                Console.WriteLine("İşleme devam ediliyor.");
                Console.ReadLine();
                return true;

            }
            else
            {
                Console.WriteLine("İşlem bitiriliyor");
                Console.ReadLine();
                return false;
            }

            //do
            //{
            //    if (d1 == true)
            //    {
            //        return d1;
            //        Console.WriteLine("İşleme devam");
            //    }
            //    else
            //    {
            //        Console.WriteLine("İşlem bitti");
            //        return d1;
            //    }
            //}
            //while (d1);

        }
        public static float mutfakev(float fg)
        {
            fg = fg * 1.05f + 50;
            return fg;
        }
        public static float kucukev(float ff)
        {
            if (ff > 500 && ff < 750)
            {
                ff *= 1.05f;
                return ff;
            }
            else if (ff > 750)
            {
                ff *= 1.1f;
                return ff;
            }
            else
            {
                return ff;
            }


        }
        public static int fatura(int fiyat, int kdv)
        {
            fiyat += fiyat * kdv / 100;
            fiyat = indirim(fiyat);
            return fiyat;
        }
        public static int indirim(int fatura)
        {
            Console.WriteLine("İndirim fiyatını gir");
            int ifiyat = Convert.ToInt32(Console.ReadLine());
            fatura -= ifiyat;
            return fatura;
        }
        public static void HediyeCeki()
        {
            Console.WriteLine("Hediye çekiniz var mı ?");
            string cvp = Console.ReadLine();
            if (cvp == "evet")
            {
                Console.WriteLine("Karaca nevresim takımında 100 tl indirim kazanabilirsiniz kaçırmayın");
            }
            else
            {
                Console.WriteLine("2500 tl üzerinde alışveriş yapanlara 200 tl hediye çekilişi var sende katıl...");
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("*****ÖZ ZÜCCACİYE ******");
            Console.WriteLine("1-Nevresim Takımı");
            Console.WriteLine("2-Bardak Çanak");
            Console.WriteLine("3-Ev Aletleri");
            Console.WriteLine("Ürün seçiniz.");
            int urunal = Convert.ToInt32(Console.ReadLine());
            switch (urunal)
            {
                case 1:
                    Console.WriteLine("Fiyat Giriniz");
                    int fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("KDV tutarı hesaplat");
                    int kdv = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ödemeniz gereken tutar : " + fatura(fiyat, kdv));
                    HediyeCeki();
                    devam(false);
                    break;
                case 2:
                    Console.WriteLine("İndirimden kazanmak istersen Devam yaz.");
                    string a = Console.ReadLine();
                    if (a == "devam" || a == "DEVAM" || a == "Devam")
                    {
                        Console.WriteLine("Fiyat Giriniz");
                        int fiyat1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("KDV tutarı hesaplat");
                        int kdv1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ödemeniz gereken tutar : " + fatura(fiyat1, kdv1));

                    }
                    HediyeCeki();
                    devam(false);
                    break;
                case 3:
                    // ev aletlerinde lüçük ev aletleri mutfak ev aletleri 2 seçenek mutfak ev aletlerinde fiyat eğer 500 ve 750 arasındaysa %5 zam 750den fazlaysa %10 zam
                    Console.Clear();
                    Console.WriteLine("1- Küçük Ev Aletleri");
                    Console.WriteLine("2- Mutfak Aletleri");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.WriteLine("Küçük Ev Aletleri");
                        Console.WriteLine("Lütfen fiyatınızı giriniz.");
                        float ff = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Zamlı fiyatınız : " + kucukev(ff));
                    }
                    else
                    {
                        Console.WriteLine("Mutfak Aletleri");
                        Console.WriteLine("Lütfen fiyatınızı giriniz.");
                        float fg = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Alış fiyatınız : " + mutfakev(fg));

                    }
                    HediyeCeki();
                    devam(false);
                    break;
            }
        }
    }
}