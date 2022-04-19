using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 ile 200 arasındaki sayıları 5er arttırarak toplamını bulan program 

            // dışarıdan girilen başlangıç ve bitiş değerine göre aralarında veya 7 bmküenler,mn adadedini be toplamını gösteren program
            int toplam = 0;
            for (int i = 100; i <= 200; i += 5)
            {
                Console.WriteLine("i değerleri : " + i);
                toplam += i;
            }
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadLine();
        }
    }
}