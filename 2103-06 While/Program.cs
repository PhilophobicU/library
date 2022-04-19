using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //while  -----> koşul kontrol yapabiliriz.(true/false) ayrı ayrı tanımla 
            //for ---> tüm ifadeleri tanımla yapıabilir.

            int nm = 0;

            while (nm < 100)
            {
                nm++;
                Console.WriteLine("Sayı değeri : " + nm);
            }
            Console.ReadLine();
        }
    }
}