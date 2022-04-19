using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1803_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen taban giriniz.");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üs giriniz");
            int us = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;

            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            Console.WriteLine("Sonuç = " + sonuc);
            Console.ReadLine();
        }
    }
}
//taban hesabı yapan program 2 üzeri 3 gibi cevap vericek döngü ile bu yapıyı kur