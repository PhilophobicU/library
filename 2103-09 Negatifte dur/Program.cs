using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // negatif sayı girice sonlanan döngüdeki sayıların toplamı
            int nm = 0;
            int toplam = 0;
            while (nm > -1)
            {
                Console.WriteLine("Sayı girişi : ");
                nm = Convert.ToInt32(Console.ReadLine());
                toplam += nm;

            }
            Console.WriteLine("Sayıların toplamı = " + toplam);
            Console.ReadLine();
        }
    }
}