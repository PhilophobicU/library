using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayac = 0;

            Console.WriteLine("Lütfen bir sayı giriniz.");
            int nm = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= nm; i++)
            {
                if (i % 7 == 0)
                {
                    sayac++;
                    toplam += i;
                    Console.WriteLine("Sayı = " + i);
                }
            }
            Console.WriteLine("Sayıların Toplamı = " + toplam);
            Console.WriteLine("Sayı adedi = " + sayac);
            Console.ReadLine();
        }
    }
}