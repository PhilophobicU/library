using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_15_iki_basamaklıysa_20_3se_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen 10 üründen fiyatı 2 basamaklıysa %20 zam, 3 basmaklıysa %50 zam yapan program

            float[] fiyat = new float[10];
            float[] zamli = new float[10];
            float topf = 0;
            float zamf = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Lütfen ürün fiyatını giriniz.");
                fiyat[i] = Convert.ToSingle(Console.ReadLine());
                topf += fiyat[i];
                
                if (fiyat[i] < 100)
                {
                    Console.WriteLine("Zamsız fiyat : "+fiyat[i]);
                    zamli[i] = fiyat[i]*1.2f;
                    Console.WriteLine("%20 Zamlı fiyat : "+zamli[i]);
                    zamf += zamli[i];
                }
                else if (fiyat[i] <999)
                {
                    Console.WriteLine("Zamsız fiyat : "+fiyat[i]);
                    zamli[i] = fiyat[i] * 1.5f;
                    Console.WriteLine("%50 Zamlı fiyat : "+zamli[i]);
                    zamf += zamli[i];
                }
                else
                {
                    Console.WriteLine("Böyle bir fiyatımız bulunmamaktadır.");
                }
            }
            Console.WriteLine("Zamlı toplam : "+zamf);
            Console.WriteLine("Zamsız toplam : "+topf);
            Console.ReadLine();




        }
    }
}
