using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //random olarak atılan 10 degerden tek olanların ve 3 e bölünenlerin adedi diğerlerinin ise çarpımını veren program

            Random rndm = new Random();
            int sayac = 1;
            int tekadet = 0;
            int ucebol = 0;
            int sonuc = 1;

            while (sayac < 11)
            {
                int nm = rndm.Next(1, 10);
                Console.WriteLine("Rastgele seçilen sayı " + nm);
                sayac++;
                if (nm % 2 == 1)
                {
                    tekadet++;
                }
                else if (nm % 3 == 0)
                {
                    ucebol++;
                }
                else
                {
                    sonuc *= nm;
                }

            }
            Console.WriteLine("Çarpımların sonucu = " + sonuc);
            Console.WriteLine("Tek sayıların adedi = " + tekadet);
            Console.WriteLine("Uce bölüm adet = " + ucebol);
            Console.ReadLine();






        }
    }
}