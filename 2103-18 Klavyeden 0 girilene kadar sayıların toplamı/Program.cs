using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_18_Klavyeden_0_girilene_kadar_sayıların_toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int nm;


            do
            {
                Console.Write("Sayı giriniz : ");
                nm = Convert.ToInt32(Console.ReadLine());
                sum += nm;
            }
            while (nm != 0);
            {

            }
            Console.WriteLine("Sayıların Toplamı = "+sum);
            Console.ReadLine();
        }
    }
}
