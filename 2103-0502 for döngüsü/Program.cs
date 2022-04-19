using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_0502
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 1, carp = 1, sonuc = 1;
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    Console.WriteLine(i + "x" + x + "=" + i * x);
                }
                Console.WriteLine("----------------------");
            }
            Console.ReadLine();
        }
    }
}
