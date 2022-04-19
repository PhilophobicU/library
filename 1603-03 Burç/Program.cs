using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string element = Console.ReadLine();

            switch (element)
                {
                case "ateş":
                    Console.WriteLine("Ateş grubu koç, yay ve aslandır");
                    break;

                case "toprak":

                    break;

                case "hava":

                    break;

                case "su":

                    break;

                default:
                    Console.WriteLine("Tekrar deneyin yanlış girdiniz");
                    break;
            }

            Console.WriteLine("Hoşçakalın");
            Console.ReadLine();
        }
    }
}
