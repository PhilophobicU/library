using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // dışarıdan girilen eleman degerine göre randım 10 ile 200 arasında fyat atan ve fiyat 100 den küçükse %2 komisyon alan 
            //100den büyük ise %5 komisyon alan ve toplam komisyon değerini veren program


            Console.WriteLine("Kaç ürün girmek istiyorsunuz?");
            int a = Convert.ToInt32(Console.ReadLine());
            float[] nm = new float[a];
            float topkom = 0;

            Random rndm = new Random();

            for (int i = 0; i < a; i++)
            {

                nm[i] = rndm.Next(10, 200);
                Console.WriteLine("Değer = " + nm[i]);

                if (nm[i] < 100)
                {
                    Console.WriteLine("Alınan komisyon %2 = " + (nm[i] * 0.02f));
                    topkom += (nm[i] * 0.02f);
                }
                else
                {
                    Console.WriteLine("Alınan komisyon %5 = " + (nm[i] * 0.05f));
                    topkom += (nm[i] * 0.05f);
                }


            }
            Console.WriteLine();
            Console.WriteLine("Toplam komisyon miktari = " + topkom);
            Console.ReadLine();







        }
    }
}