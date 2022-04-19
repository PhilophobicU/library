using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2403_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = Console.ReadLine();
            string ekle = " ";


            for (int i = 0; i < metin.Length; i++)
            {
                ekle += (metin[i]);
                Console.WriteLine(ekle);
            }
            Console.ReadLine();
        }
    }
}