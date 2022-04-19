using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_07
{
    class Program
    {
        
       
        static void  Main(string[] args)
        {
            Oteller otl = new Oteller();
            //oteller
            //--------
            //otelNo                   1. kural otel no sadece 4 haneli olabilir
            //otelAdi                   2. kural kalite 3 yıldızdan aşığı ise kapanacak diye not bırak
            //otelKalite                 3. kural kalcağı gün 2 günden az kalamaz
            //otelPuan                     
            //gunluk fiyat                  
            //kalcağı gün                       ek ozellik otel kalite otel puan kalite 4> ise ve puan 7> fiyat kalcağı gün
            //a) sauna b) jakuzi 
            // seçim yapınız switch            eğer sauna olursa fiyata +%20   b ise fiyata +%15  c) ikiside fiyat +%20+12,5
            // fatura ödeme return
            // fiyati kalcağı gün
            // kalcağı gün>3 ve 5 arasındaysa fiyat +%2 ötv
            // kalcağıgün >5 ve 8 arasında ise
            //fiyat +8kdv
            // kral odası switch
            // standart oda
            
            
            
            otl.Anasayfa();

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Write("Otel no giriniz : ");
                    otl.OtelNo = Console.ReadLine();
                    Console.Write("Otel adi giriniz : ");
                    otl.OtelAdi = Console.ReadLine();
                    Console.Write("Otel kalite giriniz : ");
                    otl.OtelKalite = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Otel puan giriniz : ");
                    otl.OtelPuan = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Otel günlük ücreti giriniz : ");
                    otl.GunlukFiyat = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Kalacağınız günü giriniz : ");
                    otl.KalacagiGun = Convert.ToInt32(Console.ReadLine());
                    otl.EkOzellik();
                    otl.FaturaHesap();
                    break;
                case 2:

                    break;
            }
            Console.ReadLine();
        }
    }
}
