using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2303_07
{
    class Program
    {
        static void Teksayi(int sayi)
        {
            int sayac = 0;
            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 != 0)
                {
                    sayac++;
                }
            }
            Console.WriteLine("Tek sayı adedi : " + sayac);
        }
        static void Sayiitse()
        {
            Console.WriteLine("Sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Teksayi(sayi);
        }
        static void Main(string[] args)
        {
            Sayiitse();
            Console.ReadLine();
        }


    }
}