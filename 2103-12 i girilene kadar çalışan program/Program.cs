using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // i girilene kadar çalışan program

            char harf = ' ';
            string birlestir = null;

            while (harf != 'i')
            {
                Console.Write("Bir harf giriniz : ");
                harf = Convert.ToChar(Console.ReadLine());
                birlestir += harf;

            }
            Console.WriteLine(birlestir);
            Console.ReadLine();

        }
    }
}
