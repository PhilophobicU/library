using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den 20 ye kadar olan tek sayıların çarpımı 
            int sayac = 1;
            int sayi = 0;
            int toplam = 1;
            do
            {
                sayi++;
                if (sayi % 2 == 1)
                {
                    Console.WriteLine("sayılar" + sayi);
                    toplam *= sayi;
                    sayac++;
                }
            }
            while (sayi < 20);
            {

            }
            Console.WriteLine("Sayı = " + toplam);
            Console.ReadLine();
        }
    }
}
// 10 tane öğrencinin notu alınarak ortalama hesaplanacak
// klavyecen sıfır sayısını girene kadar sayıların toplamını bulan program
// Kullanıcı adı ve şifre doğrı ise aşağıdaki yönlendirmeyi yapan ve yönledirme için if koşulu kullanan programı yazınız do while
//cw    yönetici sayfasına hoşgeldiniz
//cw yapmak istediğiniz işlemi seçiniz
//cw  1* kullanıccı kayıt ekle 
// cw 2. aktvasyon işlemi
//1 ile 100 arasında rastgele sayı üretin , üretilen sayu 50 olana kadar üretilen sayuları yazaan progrma
