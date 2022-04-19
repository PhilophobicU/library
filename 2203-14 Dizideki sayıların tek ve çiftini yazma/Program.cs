using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizideki sayıları önce tekleri sonra çiftleri yazan program

            // girilen ismin dizide kaçıncı sırada olduğunu bulam program

            //dizi bensersiz sayılarla dolduruluyor
            //dizi dolduruldu ekrana yazdırılıyor 
            //10 sayı üret hepsi birbirinden farklı olsun

            int tek = 0;
            int cift = 0;

            int[] sayi = new int[8];
            int a = 0;
            int b = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz.");
                sayi[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayılar : " + sayi[i]);

                if (sayi[i] % 2 == 0)
                {
                    cift++;                
                }
                else
                {
                    tek++;                
                }
            }

           
            int[] teks = new int[tek];
            int[] cifts = new int[cift];


            for (int i = 0; i < (tek + cift); i++)
            {
                if (sayi[i] % 2 == 0)
                {
                    cifts[b] = sayi[i];
                    b++;
                }
                else
                {
                    teks[a] = sayi[i];
                    a++;
                }
            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < (tek); i++)
            {
                Console.WriteLine("Tek sayılar : " + teks[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < cift; i++)
            {
                Console.WriteLine("Çift sayılar : " + cifts[i]);
            }
            Console.ReadLine();

        }
    }
}