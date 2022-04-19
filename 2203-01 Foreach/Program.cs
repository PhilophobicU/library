using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string harfler = "sadkgmğedwğırw";
            string rakamlar = "0123";

            foreach (char harf in harfler)
            {
                Console.WriteLine(harf);
                Console.ReadKey();
            }

            foreach (char rakam in rakamlar)
            {
                Console.WriteLine(rakam);
                Console.ReadKey();
            }
        }
    }
}
