using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 elemanlı diziye rasgele -50 +50 arası sayılar atan ve daha sonra dizinin elemanlarını pozitif sayı adetini negatif sayı adetini negatif sayı adetini ve işaretsiz sayı adetini ekranda gösteren program



            Random rndm = new Random();
            int[] dizi = new int[10];
            int neg = 0;
            int pos = 0;
            int isa = 0;

            for (int i = 0; i < 10; i++)
            {
                dizi[i] = rndm.Next(-50, 50);
                Console.WriteLine("Sayılar : " + dizi[i]);
                if (dizi[i] > 0)
                {
                    pos++;
                }
                else if (dizi[i] == 0)
                {
                    isa++;
                }
                else
                {
                    neg++;
                }
            }
            Console.WriteLine("Negatif Sayı adeti = " + neg);
            Console.WriteLine("Pozitif Sayı adeti = " + pos);
            Console.WriteLine("İşaretsiz Sayı adeti = " + isa);
            Console.ReadLine();


        }
    }
}