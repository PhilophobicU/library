using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sesli = "aeıioöuü";
            int sayac = 0;

            Console.WriteLine("Lütfen bir metin giriniz.");
            string metin = Console.ReadLine();

            foreach (char karakter in metin)
            {
                foreach (char sesliler in sesli)
                {
                    if (karakter == sesliler)
                        sayac++;
                }
            }
            Console.WriteLine("Metin uzunluğu : " + metin.Length);
            Console.WriteLine("Metindeki sesli harf sayısı : " + sayac);
            Console.ReadLine();


        }
    }
}
