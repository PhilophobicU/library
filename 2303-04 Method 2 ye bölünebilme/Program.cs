using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2303_05
{
    class Program
    {
        static void Tekcift(int sayi)
        {
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Bu sayı çift.");
            }
            else
            {
                Console.WriteLine("Bu sayı tek.");
            }
        }
        static void Main(string[] args)
        {
            // dışarıdan girilen tek mi çift mi kontrolü
            Console.WriteLine("Lütfen sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Tekcift(sayi);
            Console.ReadLine();
        }
    }
}
