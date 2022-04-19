using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //karşılaştırma operatörleri
            // == 2 değişken arasında karşılaştırma yapıyor
            // && ve anlamında kullanu
            //|| veya anlamına gelir
            // >=
            //<=
            // = atama yapmak için kullanılır
            //% mod alma operatörü

            // kontrol mekanizması
            // if else kullanıcaz
            // if ( eğer) else (değilse)

            Console.WriteLine("1. Sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi > sayi2)
            {
                Console.WriteLine("1. Sayı daha büyük değerdir.");
            }
            else
            {
                Console.WriteLine("2. Sayı daha büyük değerdir");
            }
            Console.ReadLine();
        }
    }
}