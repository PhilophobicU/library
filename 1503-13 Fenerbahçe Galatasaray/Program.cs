using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random skor = new Random();

            int fb = skor.Next(0, 3);
            int gs = skor.Next(0, 3);

            if (fb == gs)
            {
                Console.WriteLine("Berabere Kaldınız...");
                Console.WriteLine("fb skor : " + fb);
                Console.WriteLine("gs skor : " + gs);
            }
            else if (fb > gs)
            {
                Console.WriteLine("Fenerbahçe Kazandı.");
                Console.WriteLine("fb skor : " + fb);
                Console.WriteLine("gs skor : " + gs);
            }
            else
            {
                Console.WriteLine("Galatasaray Kazandı");
                Console.WriteLine("fb skor : " + fb);
                Console.WriteLine("gs skor : " + gs);
            }
            Console.ReadLine();
        }
    }
}