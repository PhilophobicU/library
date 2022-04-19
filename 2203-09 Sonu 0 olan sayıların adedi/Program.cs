using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // dışarıdan diziye girilen 10 elemandan sonu 0 olan sayıların adedini yazan program


            int[] nm = new int[10];
            int sayac = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Lütfen " + (i + 1) + ". Değerinizi giriniz.");
                nm[i] = Convert.ToInt32(Console.ReadLine());
                if (nm[i] % 10 == 0)
                {
                    sayac++;
                }
            }
            Console.WriteLine("Sonu 0'lı olan sayı adedi : " + sayac);
            Console.ReadLine();









        }
    }
}