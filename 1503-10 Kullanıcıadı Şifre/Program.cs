using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_10
{
    class Program
    {
        static void Main(string[] args)
        {
        git:
            Console.WriteLine("Kullanıcı adı giriniz");
            string kadi = Console.ReadLine();
            Console.WriteLine("Şifre giriniz");
            int sifre = Convert.ToInt32(Console.ReadLine());
            if (kadi == "admin" && sifre == 1234)
            {
                Console.WriteLine(kadi + " Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız");
                Console.WriteLine("Tekrar denemek ister misiniz ?<e/h>");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'E' || cevap == 'e')
                {
                    Console.Clear(); // ekranı temizler
                    goto git;  // döngü mantığında istediğimiz yere yönlendirme yapar.
                }
                else
                {
                    Console.WriteLine("Hoşçakalın");
                    Environment.Exit(0); // Uygulamayı kapatır.
                }
            }
            Console.ReadLine();    
        }

    }
}