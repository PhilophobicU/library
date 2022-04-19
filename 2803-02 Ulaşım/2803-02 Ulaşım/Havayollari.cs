using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_02_Ulaşım
{
    internal class Havayollari:Ulasim
    {


        public void HavaYollariSorular()
        {
            Console.WriteLine("Hava yollarına hoşgeldiniz.");
            Console.WriteLine("Lütfen isminizi giriniz");
            IsımSoyisim = Console.ReadLine();
            Console.WriteLine("Lütfen seyehat etmek istediğiniz firmayı giriniz.");
            FirmaAdi = Console.ReadLine();
            Console.WriteLine("Lütfen uçağınızda tercih ettiğiniz motor sayısını giriniz.");
            MotorSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bagaj ağırlınızı giriniz.");
            BagajKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen kalite belirtiniz 1 veya 2");
            SeferKalite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen sefer günü belirtiniz.");
            SeferGunu = Console.ReadLine();
            Console.WriteLine("Gidilecek km mesafe");
            Ucuskm = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("Bahaj için ödenmesi gereken "+BagajTop());
            Console.WriteLine("Ödenecek bilet fiyatı : " + UcakBiletFiyatHesap());

        }
        public double BagajTop()
        {
            BagajToplam = BagajFiyati * BagajKg;
            return BagajToplam;
        }
        public double Firmalar()
        {
            if (FirmaAdi == "pegasus" && MotorSayisi >= 3)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
