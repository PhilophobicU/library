using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1803_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen 10 sayıyı toplayıp 5. sayıya bölen program 
            int bes = 0;
            int topla = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Lütfen " + i + ". sayıyı giriniz");
                int nm = Convert.ToInt32(Console.ReadLine());
                topla += nm;
                if (i == 5)
                {
                    bes += nm;
                }

            }
            int sonuc = topla / bes;
            Console.WriteLine("Toplamın 5. sayıya bölümü = " + sonuc);
            Console.ReadLine();
        }
    }
}
