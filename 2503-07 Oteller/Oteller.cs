using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_07
{
    class Oteller
    {
        public double fatura = 0;
        private string otelNo;
        private string otelAdi;
        private int otelKalite;
        private int otelPuan;
        private float gunlukFiyat;
        private int kalacagiGun;
        int sau = 0;
        int jaku = 0;
        int iku = 0;
        public string OtelNo
        {
            get { return otelNo; }
            set
            {
                if (4 == value.Length)
                {
                    otelNo = value;
                }
                else
                {
                    Console.WriteLine("Yanlış tuşlama yaptınız.");
                }

            }
        }
        public string OtelAdi
        {
            get { return otelAdi; }
            set { otelAdi = value; }
        }
        public int OtelKalite
        {
            get { return otelKalite; }
            set
            {
                if (value <= 3)
                {
                    Console.WriteLine("Otel kapanıyor by");
                    Console.ReadLine();
                    Environment.Exit(0);
                    
                }
                else if(value >= 6)
                {
                    Console.WriteLine("Kalite max 5 olabilir");
                }
                else if(value <= 0)
                {
                    Console.WriteLine("Kalite min 1 olabilir");
                }
                else 
                {
                    otelKalite = value;
                }
            }
        }
        public int OtelPuan
        {
            get { return otelPuan; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Minimum puan 0'dır.");
                }
                else if (value >= 11)
                {
                    Console.WriteLine("Maximum puan 10'dur.");
                }
                else
                {
                    { otelPuan = value; }
                }
            }
        }
        public float GunlukFiyat
        {
            get { return gunlukFiyat; }
            set { gunlukFiyat = value; }
        }
        public int KalacagiGun
        {
            get { return kalacagiGun; }
            set
            {
                if (value <= 2)
                {
                    Console.WriteLine("2 Günden az kalamazsınız.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    kalacagiGun = value;
                }
            }

        }
       
        public void Anasayfa()
        {
            Console.WriteLine("Otel listemize hoşgeldiniz.");
            Console.WriteLine("Lütfen otel seçimi yapınız.");
            Console.WriteLine("1- Kral odası");
            Console.WriteLine("2- Standart oda");


        }
        public void EkOzellik()
        {
            if (otelKalite >= 4 && otelPuan >= 7)
            {
                Console.WriteLine("Tebrikler Otelimizin ek özelliklerine eriştiniz");
                Console.WriteLine("Lütfen seçim yapınız.");
                Console.WriteLine();
                Console.WriteLine("1- Sauna");
                Console.WriteLine("2-Jakuzi");
                Console.WriteLine("3- İkiside");
                int sec = Convert.ToInt32(Console.ReadLine());
                switch (sec)
                {
                    case 1:
                        Console.WriteLine("Sauna özelliğiniz aktif edilmiştir.");
                        sau = 1;
                        break;
                    case 2:
                        Console.WriteLine("Jakuzi özelliğiniz aktif edilmiştir.");
                        jaku = 1;
                        break;
                    case 3:
                        Console.WriteLine("İki özelliğinizde aktif edilmiştir.");
                        iku = 1;
                        break;
                }
            }
        }
        public double FaturaHesap()
        {
            fatura = kalacagiGun * gunlukFiyat;
            if (kalacagiGun >= 3 && kalacagiGun <= 5)
            {
                fatura *= 1.02;
            }
            else if(kalacagiGun >= 5 && kalacagiGun <= 8)
            {
                fatura *= 1.08;
            }
            if (sau == 1)
            {
                fatura *= 1.2;
            }
            if (jaku == 1)
            {
                fatura *= 1.15;
            }
            if (iku == 1)
            {
                fatura *= 1.20;
                fatura *= 1.125;
            }
            Console.WriteLine("Ödemeniz gereken tutar : "+fatura);
            return fatura;
        }
    }
}
