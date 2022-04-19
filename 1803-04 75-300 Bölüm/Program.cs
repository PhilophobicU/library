using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1803_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //75ten 300e kadar girilen sayısına bölünen sayıların adedi
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int nm = Convert.ToInt32(Console.ReadLine());

            int adet = 0;

            for (int i = 75; i <= 300; i++)
            {
                if (i % nm == 0)
                {
                    adet++;
                }
            }
            Console.WriteLine("Sayıların adedi = " + adet);
            Console.ReadLine();
        }
    }
}
