using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1803_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı giriniz.");
            int ucb = 0;
            float toplam = 0;

            for (int i = 1; i < 100; i++)
            {
                int nm = Convert.ToInt32(Console.ReadLine());
                if (nm > 99 && nm < 1000)
                {
                    ucb++;
                    Console.WriteLine("Bu sayı üç basamaklıdır.");
                }
                else
                {
                    Console.WriteLine("Bu sayı toplama ekleniyor.");
                    toplam += nm;
                    Console.WriteLine("Toplam = " + toplam);
                }

            }
            Console.ReadLine();
        }
    }
}
// 10 sayı gir   100 999
// 3 basamaklıları ayrı bir sayaçta tut adedi,ni göster
//geri kalanları topla