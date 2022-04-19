using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayının 0 kontolü
            //yapılıp 0 ise btr depilse negatif mi pozitif molduğu program,

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                Console.WriteLine("Sayı nötr");
            }
            else if (sayi > 0)
            {
                Console.WriteLine("Girdiğiniz sayı pozitif");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı negatif");
            }

            Console.ReadLine();
        }
    }
}