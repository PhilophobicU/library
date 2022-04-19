using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilgisayar random bir sayı atıyor kullanıcı ksayi =random tebrikler şu kadar adımda bildiniz
            // büyük değer girdiniz küçük değer girdiniz

            Random pc = new Random();
            int sayi = pc.Next(1, 11);
            int sayac = 1;
        git:
            Console.WriteLine("Bir Sayı giriniz");
            int kul = Convert.ToInt32(Console.ReadLine());
            if (kul == sayi)
            {
                Console.WriteLine("Tebrikler " + sayac + "  defada tahmin Ettiniz");
            }
            else if (kul > sayi)
            {
                Console.WriteLine("Girdiğiz değer büyük");
                sayac++;
                goto git;
            }
            else
            {
                Console.WriteLine("Girdiğiniz değer küçük");
                sayac++;
                goto git;
            }
            Console.ReadLine();

        }
    }
}