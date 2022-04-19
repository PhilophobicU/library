using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16032022_1
{
    class Program
    {
        static void Main(string[] args)
        {
        //+ ya basıldığı zaman topalama -ye basıldığı zaman çarpma / yapılığında bölme % işareti mod alma
        //iki sayı girilecek seçeneğe göre işlen yapılacak
        Bas:
            Console.Clear();
            Console.WriteLine("Birinci sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen yapmak istediğiniz işlem simgesini giriniz");
            char isl = Convert.ToChar(Console.ReadLine());

            char top = '+';
            char çık = '-';
            char çar = '*';
            char bol = '/';
            char mod = '%';

            int topl = sayi1 + sayi2;
            int çıkarma = sayi1 - sayi2;
            int çarpma = sayi1 * sayi2;
            int bölme = sayi1 / sayi2;
            int modal = sayi1 % sayi2;

            if (isl == top)
            {
                Console.WriteLine("İşlem sonucu =" + topl);
                goto tek;
            }
            else if (isl == çık)
            {
                Console.WriteLine("İşlem sonucu =" + çıkarma);
                goto tek;
            }
            else if (isl == çar)
            {
                Console.WriteLine("İşlem sonucu =" + çarpma);
                goto tek;
            }
            else if (isl == bol)
            {
                Console.WriteLine("İşlem sonucu =" + bölme);
                goto tek;
            }
            else
            {
                Console.WriteLine("İşlem sonucu =" + modal);
                goto tek;
            }
        tek:
            Console.WriteLine("Tekrar işlem yapmak ister misiniz ?");
            char yanıt = Convert.ToChar(Console.ReadLine());

            if (yanıt == 'e' || yanıt == 'E')
            {
                goto Bas;
            }
            else
            {
                Console.WriteLine("İşlemi bitirdiniz");
            }
            Console.ReadLine();
        }
    }
}
// otopark sistemi 
//abonelik var ise 
//aracın kaldığı süreç
// 0-2 10 tl   2-8 arası 20 tl 
// 8 -24 40 tl  

//abonelik yok ise    0-2 20 t    2-8 40    8-24   80 tl