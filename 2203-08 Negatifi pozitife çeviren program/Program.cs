using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_08
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizideki içeriden  tanımlanmış negatif sayıları pozitife çeviren program

            int[] sayilar = { 5, -2, 9, -11, 8 };

            for (int i = 0; i < 5; i++)
            {
                if (sayilar[i] < 0)
                {
                    Console.WriteLine((i + 1) + ". sayının asıl değeri " + sayilar[i] + "'ken pozitife çevirildi.");
                    sayilar[i] *= -1;
                }
                Console.WriteLine((i + 1) + ". Sayı : " + sayilar[i]);
            }
            Console.ReadLine();



        }
    }
}