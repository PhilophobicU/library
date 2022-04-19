using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den 100e kadar çift sayıların toplamını bulan program

            int toplam = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                    Console.WriteLine("Çift Sayılar = " + i);
                }
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}