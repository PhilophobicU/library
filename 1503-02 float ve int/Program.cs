using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 25;
            int sayi1 = 100;
            int toplam = sayi + sayi1;
            Console.WriteLine("Toplam sonucu : " + toplam);
            char cinsiyet = 'E';
            float fiyat = 25.5f;
            float indirim = 5.3f;
            float tutar = fiyat - indirim;
            bool secenek = true;
            Console.WriteLine("Cinsiyet : " + cinsiyet);
            Console.WriteLine("Tutar : " + tutar);
            Console.WriteLine("Secenek degeri :" + secenek);
            Console.ReadLine();
        }
    }
}