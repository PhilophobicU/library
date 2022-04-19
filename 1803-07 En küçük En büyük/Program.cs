using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1806_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen 10 sayıdan en büyük ve en küçük olanı ekrana yazdıracak 

            int enb = 0;
            int enk = 0;
            int kkontrol = 0;
            int bkontrol = 0;

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz");
               
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    kkontrol = sayi; 
                    bkontrol = sayi;
                }
                i++;

                if (sayi > bkontrol)
                {
                    bkontrol = sayi ;
                    enb = bkontrol;
                }
                else if (sayi < kkontrol)
                {   
                    kkontrol = sayi;
                    enk = kkontrol;
                }
                
            }
            Console.WriteLine("En büyük sayı = " + enb);
            Console.WriteLine("En küçük sayı = " + enk);
            Console.ReadLine();
        }
    }
}