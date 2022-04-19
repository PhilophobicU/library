using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_02_Ulaşım
{
    internal class Karayolları:Ulasim
        
    {
        Random random = new Random();

       
        public void KaraYollariSorular()
        {
            Console.Write("İsim ve Soyisim : ");
            IsımSoyisim = Console.ReadLine();
            Console.WriteLine("****Bilgilendirme****");
            Console.WriteLine("Durak Listesi");
            for (int i = 0; i < 14; i++)
            {                
                Console.WriteLine(duraklar[i]);
            }
            
            Console.Write("Gideceğiniz durak sayısı[max 14] : ");
            DurakSayisi = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Müsait olan koltuklar");
            Console.WriteLine();
            karaboskoltuklar();
        git2:
            Console.WriteLine("Seçtiğiniz koltuk : ");
            KoltukNumara = Convert.ToInt32(Console.ReadLine());

            if (KoltukNumara == 44 || KoltukNumara == 45 || KoltukNumara == 27 || KoltukNumara == 28)
            {
                Console.WriteLine("Bu koltuklar daha önceden satın alınmış.");
                Console.WriteLine("Lütfen tekrar seçiniz.");
                goto git2;

            }
            Console.Write("Ödiyeceğiniz tutar : " + BiletFiyatHesap());
            

            Console.WriteLine(" Rezervasyon yapmak ister misiniz ? <e/h>");
            Rezervasyon = Convert.ToChar(Console.ReadLine());
            if (Rezervasyon == 'e' || Rezervasyon == 'E')
            {
                Console.WriteLine(" Rezervasyon işleminiz gerçekleşti.");
                Console.WriteLine("Sayın " + IsımSoyisim + " " + KoltukNumara + " numaralı koltuk "+random.Next(1000,9999) +" p adınıza ayırılmıştır");
            }
            else
            {
                Console.WriteLine("Rezervasyonunuz iptal edildi.");
            }


        }
        public void karaboskoltuklar()
        {
            Console.WriteLine("1-2  3-4");
            Console.WriteLine("5-6  7-8");
            Console.WriteLine("9-10  11-12");
            Console.WriteLine("13-14  15-16");
            Console.WriteLine("17-18  19-20");
            Console.WriteLine("21-22  23-24");
            Console.WriteLine("25-26  X-X");
            Console.WriteLine("29-30  30-31");
            Console.WriteLine("32-33  34-35");
            Console.WriteLine("36-37  38-39");
            Console.WriteLine("40-41  42-43");
            Console.WriteLine("X-X  46-47");

        }
        
    }
}
