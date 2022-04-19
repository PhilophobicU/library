using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //dışardan girilen 5 elemanlı bir dizide tek sayı olanların adedini gösteren 


            int[] sayi = new int[5];
            int sayac = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + ". Sayınızı giriniz.");
                sayi[i] = Convert.ToInt32(Console.ReadLine());

                if (sayi[i] % 2 == 1)
                {
                    sayac++;
                }
            }

            Console.WriteLine("Tek sayıların adedi : " + sayac);
            Console.ReadLine();






        }
    }
}
