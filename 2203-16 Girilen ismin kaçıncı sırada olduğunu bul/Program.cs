using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_16_Girilen_ismin_kaçıncı_sırada_olduğunu_bul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            string[] isimler = new string[10] { "fatih", "samet", "okan","batuhan","gxusk","burak","babuz","Jargen","Karaman","Halit"};

            Console.WriteLine("Listedeki isimler ...");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.WriteLine("Lütfen isim giriniz");
            string nme = Console.ReadLine();
            foreach (string nick in isimler)
            {
                sayac++;
                if (nick == nme)
                {
                    break;
                }
                
            }
            Console.WriteLine(sayac+". sırada bulunuyor");
            Console.ReadLine();
        }
    }
}
