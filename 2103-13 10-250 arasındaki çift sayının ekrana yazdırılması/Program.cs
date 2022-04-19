using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 250 - 10 arasında rastgele 10 çift sayının ekrana yazdırılması
            Random rndm = new Random();

            int x = 1;

            while (x < 11)
            {

                int sayi = rndm.Next(10, 250);
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(x + ". çift sayı = " + sayi);
                    x++;
                }

            }
            Console.ReadLine();
        }
    }
}