using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int nm = 0, tp = 0;
            while (nm % 2 != 1)
            {
                tp = tp + nm;
                Console.WriteLine("Bir Sayı giriniz.");
                nm = Convert.ToInt16(Console.ReadLine());

            }
            Console.WriteLine("Girilen çifgt sayıların toplamı= " + tp);
            Console.ReadLine();
        }
    }
}