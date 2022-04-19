using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[5];
            //string olarak kaç elemanlı olduğunu sor verileri al sonra yazdır,

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Lütfen " + (i + 1) + ". ismi giriniz");
                isimler[i] = Console.ReadLine();
            }

            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine("Girilen " + (a + 1) + ". isim :" + isimler[a]);
            }
            Console.ReadLine();




        }
    }
}
