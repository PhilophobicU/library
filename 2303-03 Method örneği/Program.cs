using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2303_04
{
    class Program
    {
        public static void Mesaj()// geriye değer döndürmeyen parametresiz bir method.
        {
            Console.WriteLine("Hoşgeldiniz Canlar....");
        }
        public static void GelenBilgi(int yas, string adsoyad)// geriye değer döndürmeyen parametreli bir method.
        {
            if (yas > 18)
            {
                Console.WriteLine(adsoyad + "sitemize katılım kazandınız ver paraları...");
            }
            else
            {
                Console.WriteLine(adsoyad + "Büyüyünce gel.");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("İşkur oyun grubu game devoloperlar");
            Mesaj();
            Console.WriteLine("Yallah işe");
            Console.WriteLine("Ad soyad giriniz : ");
            string adsoyad = Console.ReadLine();
            Console.WriteLine("Yaş giriniz. ");
            int yas = Convert.ToInt32(Console.ReadLine());
            GelenBilgi(yas, adsoyad);
            Console.ReadLine();
        }
    }
}