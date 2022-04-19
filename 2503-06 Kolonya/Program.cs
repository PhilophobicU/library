using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //korumalı kontrollü bir şekilde kullanıcıya açma

            Kolanyalar k1 = new Kolanyalar();
            k1.Markaadi = "eyüp sabri tuncer";
            k1.Fiyat = 30;
            k1.Uretim = 2021;

            Console.WriteLine("Marka adı : "+k1.Markaadi);
            Console.WriteLine("Fiyat : "+k1.Fiyat);
            Console.WriteLine("Uretim yili : "+k1.Uretim);
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
