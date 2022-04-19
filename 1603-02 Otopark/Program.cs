using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603_2
{
    class Program
    {
        static void Main(string[] args)
        {
        st:
            Console.WriteLine("Abone numaranızı tuşlayın");

            int abn = Convert.ToInt32(Console.ReadLine());
            if (abn == 1234)
            {
                Console.WriteLine("Girdiğiniz abone numarası doğru! Lütfen kaldığınız saati giriniz.");
                int ikis = Convert.ToInt32(Console.ReadLine());

                if (ikis <= 2)
                {
                    Console.WriteLine("Ödemeniz gereken tutar : 10 TL");
                }
                else if (2 < ikis && ikis < 8)
                {
                    Console.WriteLine("Ödemeniz gereken tutar : 20 TL");
                }
                else
                {
                    Console.WriteLine("Ödemeniz gereken tutar : 40 TL");
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz abone numarası yanlış! Tekrar denemek istiyorsanız a tuşuna basınız. Eğer abonesiz fiyatlarımızdan devam etmek istiyorsanız Lütfen s tuşuna basınız.");
                char saat = Convert.ToChar(Console.ReadLine());

                if (saat == 'a')
                {
                    goto st;
                }
                else
                {
                    Console.WriteLine("Lütfen kaldığınız süreyi giriniz");
                    int ikiss = Convert.ToInt32(Console.ReadLine());
                    if (ikiss <= 2)
                    {
                        Console.WriteLine("Ödemeniz gereken tutar : 20 TL");
                    }
                    else if (ikiss < 8 && ikiss < 2)
                    {
                        Console.WriteLine("Ödemeniz gereken tutar : 40 TL");
                    }
                    else
                    {
                        Console.WriteLine("Ödemeniz gereken tutar : 80 TL");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}