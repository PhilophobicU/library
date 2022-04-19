using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703_04
{
    class Program
    {


        static void Main(string[] args)
        {
            int tektoplam = 0;
            int cifttp = 0;

            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Çift sayı = " + i);
                    cifttp += i;
                }
                else
                {
                    Console.WriteLine("Tek sayı = " + i);
                    tektoplam += i;
                }
            }
            Console.WriteLine("Tek toplam = " + tektoplam);
            Console.WriteLine("Çift Toplam = " + cifttp);
            Console.ReadLine();
        }
    }
}
