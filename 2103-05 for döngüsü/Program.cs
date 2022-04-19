using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    b = i * j;
                    Console.WriteLine("{0}*{1}={2}", i, j, b);

                }
            }
            Console.ReadLine();
        }
    }
}