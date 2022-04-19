using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // döngüler tekrarlayan işlemlerde kullanılır

            // döngü çeşitleri
            //for  sayaclı işlem
            //while sayacşı iislem
            //do while
            //foreach



            //for (int sayac = 0; sayac <= 100; sayac++)
            //{
            //    Console.WriteLine("Sayılar = "+sayac);
            //}


            for (int sayac = 100; sayac >= 0; sayac--)
            {
                Console.WriteLine("Sayılar = " + sayac);
            }
            Console.ReadLine();
        }
    }
}