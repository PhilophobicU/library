using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_20_1_100_random_50yi_bul
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int nm;
            int sayac = 1;

            do
            {
                nm = random.Next(1, 100);
                sayac++;
                Console.Write("// Sayılar "+nm +" ");
            }
            while (nm != 50);
            {

            }
            Console.WriteLine("Sayaç = "+sayac);
            Console.ReadLine();




        }
    }
}
