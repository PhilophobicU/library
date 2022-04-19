using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //elemanları gir en uzun metni bul indisi bul


            int uzunluk = 0, indis = 0;
            string enuzun = "";
            string[] dizi = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. elemanı giriniz : ", (i + 1));
                dizi[i] = Console.ReadLine();
                if (dizi[i].Length > uzunluk)
                {
                    uzunluk = dizi[i].Length;
                    enuzun = dizi[i];
                    indis = i;
                }
            }

            Console.WriteLine("En uzun metin : " + enuzun);
            Console.WriteLine("Metin indisi : " + (1 + indis));
            Console.WriteLine("Dizi uzunluğu : " + uzunluk);
            Console.ReadLine();




        }
    }
}