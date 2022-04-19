using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_04
{
    class Program
    {
        static void Main(string[] args)
        {

            //array verilen saklandığı alan 
            // saklanan bilgiler farklı çeşit olmalı 
            //array bir nevi tepsi gibi içinde barıdırabileceğimiz bardak
            // 5 lik bir dizide 0,1,2,3,4
            // döngülerde foreach ve for önemli
            //bilgilereulaşop yazdırmak istenirse foreeach


            int[] sayilar = new int[5];
            sayilar[1] = 12;
            sayilar[3] = 4;
            sayilar[4] = 11;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("dizimin değerleri : " + sayilar[i]); // ikisi arasında bir bağlantı olmalı yoksa range dışına çıkar
            //}
            //Console.ReadLine();

            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine("Değer : " +sayi);

            //}
            //Console.ReadLine();

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("Sayılar : " + sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}