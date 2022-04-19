using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 elemanlı diziye 10 ile 100 arasında resgele çift sayılar atarak bu dizideki 50den küçük sayıları listeleyen ve adetini bulup ekrana yazan program
            int adet = 0;
            int[] nm = new int[10];
            Random rndm = new Random();

            for (int i = 0; i < 10;)
            {
                int a = rndm.Next(10, 100);
                if (a % 2 == 0)
                {
                    nm[i] = a;
                    i++;

                }

            }
            for (int i = 0; i < 10; i++)
            {
                if (nm[i] < 50)
                {
                    adet++;
                    Console.WriteLine("50den küçük sayılar : " + nm[i]);
                }
            }
            Console.WriteLine(" Değeri 50den küçük sayıların adedi : " + adet);
            Console.ReadLine();






        }
    }
}