using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. değeri kaç defada bulduğunu gösterip değerleri yan yana yazdıran program

            Random rndm = new Random();
            int sayac = 0;
            int sayac2 = 1;
            Console.WriteLine("Bir Sayı giriniz : ");
            int nm = Convert.ToInt32(Console.ReadLine());

            while (sayac < 2)
            {
                int sayi = rndm.Next(1, 100);

                Console.WriteLine(sayi + " ");
                sayac2++;
                if (sayi == nm)
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac2 + " defada bulundu.");
            Console.ReadLine();

        }
    }
}