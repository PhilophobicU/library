using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2303_09
{
    class Program
    {
        public static int deger(int sayi, int nm)
        {
            if (sayi > nm)
            {
                return sayi;
            }
            else
            {
                return nm;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz.");
            int nm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Büyük olan sayımız." + deger(sayi, nm));
            Console.ReadLine();
        }
    }
}