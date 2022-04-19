using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //random istenilen sayı kadar hardf yazan program
            string harf = "abcdefghjklmnoprstuvyz";
            string uret = " ";  //null yazabiliriz
            int sayi;
            Random rastgele = new Random();

            Console.WriteLine("Kaç harfli olmasını istersiniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                uret += harf[rastgele.Next(harf.Length)];
            }
            Console.WriteLine("Üretilen harfler : " + uret);
            Console.ReadLine();
        }
    }
}