using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int hesap = 1;
            Console.WriteLine("Lütfen faktoriyelini hesaplamak istediğiniz sayıyı giriniz.");
            int fkt = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= fkt; fkt--)
            {
                hesap *= fkt;
            }
            Console.WriteLine("İşlem sonucu = " + hesap);
            Console.ReadLine();
        }
    }
}