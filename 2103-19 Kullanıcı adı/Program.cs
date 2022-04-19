using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_19_Kullanıcı_adı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Yönetici sayfasına hoşgeldiniz.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("1- Kayıt Ekle");
            Console.WriteLine("2- Aktivasyon işlemi");

            char secim1 = Convert.ToChar(Console.ReadLine());

            if (secim1 == '1')
            {
                string kadi = " ";
                string sifre = " ";

                do

                {
                    Console.WriteLine("Lütfen kullanıcı adınızı giriniz");
                    kadi = Console.ReadLine();
                    Console.WriteLine("Lütfen şifrenizi giriniz.");
                    sifre = Console.ReadLine();
                }

                while (kadi != "admin" || sifre != "123");

                {
                    Console.WriteLine("Başarıyla giriş yaptınız.");
                }
            }
                Console.ReadLine();
        }
    }
}
