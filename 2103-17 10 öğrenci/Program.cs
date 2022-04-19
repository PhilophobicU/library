using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_17_10_öğrenci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nm = 1;
            int toplam = 0;

            do
            {
                Console.WriteLine("Lütfen " + nm + ". öğrencinin notunu giriniz.");
                nm++;
                int not = Convert.ToInt32(Console.ReadLine());
                toplam += not;

            }
            while (nm <= 10);
            { 
                
            }
            int sonuc = toplam / (nm-1); // nm 11de tamamlanıyor
            Console.WriteLine("Ortalamamız : "+sonuc);
            Console.ReadLine();


        }
    }
}
