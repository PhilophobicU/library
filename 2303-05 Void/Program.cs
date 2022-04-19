using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2303_06
{
    class Program
    {
        static void login(string kad, string adsoyad, int sifre)
        {
            if (kad == "qwe" && sifre == 1234)
            {
                Console.WriteLine(adsoyad + "Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız");
            }
        }

        static void Main(string[] args)
        {
            // kullanıcı adı şifre isim soyisim
            //login ("fatih","nihal",1234);
            Console.WriteLine("İsim giriniz.");
            string isim = Console.ReadLine();
            Console.WriteLine("Kullanıcı adı");
            string kad = Console.ReadLine();
            Console.WriteLine("Şifre");
            int sifre = Convert.ToInt32(Console.ReadLine());
            login(kad, isim, sifre);
            Console.ReadLine();

        }


    }
}