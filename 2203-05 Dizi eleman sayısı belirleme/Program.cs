using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "nihoş", "pek", "hoş" };

            foreach (var item in isimler)
            {
                Console.WriteLine("isimler : " + item);
            }

            int toplam = 0;
            Console.WriteLine("Dizimin kaç elemanı olsun");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] sayi = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("dizimin " + i + ". eleman değerini giriniz.");
                sayi[i] = Convert.ToInt32(Console.ReadLine());

                toplam += sayi[i];
            }
            Console.WriteLine("dizimdeki elemanların toplamı : " + toplam);
            Console.ReadLine();
        }
    }
}