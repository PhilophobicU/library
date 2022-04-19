using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen 5 sayının karelerini, sayıların toplamını ve karelerinin toplamını bulan program

            int sayıtop = 0;
            int karetop = 0;

            int[] nm = new int[5];
            int[] kr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz.");
                nm[i] = Convert.ToInt32(Console.ReadLine());

                kr[i] = nm[i] * nm[i];

                sayıtop += nm[i];
                karetop += kr[i];
                Console.WriteLine("Sayının karesi = " + kr[i]);

            }
            Console.WriteLine("Kareler toplamı = " + karetop);
            Console.WriteLine("Sayı toplamı = " + sayıtop);
            Console.ReadLine();





        }
    }
}