using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dikdörtgenin uzun kenarını yazınız");
            int uzunkenar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin kısa kenarını yazınız");
            int kısakenar = Convert.ToInt32(Console.ReadLine());

            int alan = kısakenar * uzunkenar;

            Console.Write("Diktörtgenin alanı = " + alan);

        }
    }
}