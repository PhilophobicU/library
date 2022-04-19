using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayı tek mi çift mi ?

            Console.WriteLine("Lütfen bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen Sayı Çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Tektir.");
            }

            Console.ReadLine();
        }
    }
}