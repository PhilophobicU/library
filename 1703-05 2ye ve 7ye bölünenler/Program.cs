using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int top = 0;
            int yeditop = 0;
            int sayac = 0;
            int sayaciki = 0;
            Console.WriteLine("Lütfen başlangıç değeri giriniz.");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bitiş değerinizi giriniz.");
            int bitis = Convert.ToInt32(Console.ReadLine());

            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 == 0)
                {
                    sayac++;
                    top += i;
                }
                else if (i % 7 == 0)
                {
                    sayaciki++;
                    yeditop += i;
                }
            }
            Console.WriteLine("2ye bölünenler toplamı = " + top);
            Console.WriteLine("7ye bölünenler toplamı = " + yeditop);
            Console.WriteLine("2ye bölünen sayıların adedi = " + sayac);
            Console.WriteLine("7ye bölünen sayıların adedi = " + sayaciki);
            Console.ReadLine();
        }
    }
}