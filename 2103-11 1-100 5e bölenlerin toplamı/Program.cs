using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 ile 100 arasında rastgele tutualn sayıların sadece 5e bölenlerin toplamı 1000i bulan program

            Random rndm = new Random();
            int tplm = 0;

            while (tplm < 1000)
            {
            mm:
                int sayi = rndm.Next(1, 100);

                if (sayi % 5 == 0)
                {
                    tplm += sayi;
                    Console.WriteLine("Sayı " + sayi + " olduğu için toplama eklendi.");
                }
                else
                {
                    Console.WriteLine("Sayı " + sayi + " olduğu için toplama eklenemedi.");
                    goto mm;
                }
            }
            Console.WriteLine("Toplam = " + tplm);
            Console.ReadLine();
        }
    }
}