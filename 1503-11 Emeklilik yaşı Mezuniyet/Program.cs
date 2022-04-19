using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_11
{
    class Program
    {
        static void Main(string[] args)
        {
         git:
            Console.WriteLine("Tc kimlik numaranızı giriniz");
            int tc = Convert.ToInt32(Console.ReadLine());
            if (tc == 1234)
            {
                Console.WriteLine("Lütfen emeklilik yaşınızı giriniz");
                int emyas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lütfen Mezuniyet Derecenizi giriniz");
                string mezun = Console.ReadLine();

                if (emyas > 65 && mezun == "Lisans")
                {
                    Console.WriteLine("Emekli Olabilirsin");
                }
                else
                {
                    Console.WriteLine("Emekli olamazsın");
                }

            }
            else
            {
                Console.WriteLine("Hatalı tc girişi yaptınız");
                Console.WriteLine("Tekrar Denemek ister misiniz? <e/h>");
                char cevap = Convert.ToChar(Console.ReadLine());

                if (cevap == 'e' || cevap == 'E')
                {
                    goto git;
                }
            }
            Console.ReadLine();
        }
    }
}