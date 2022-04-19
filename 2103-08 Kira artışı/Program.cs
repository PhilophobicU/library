using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Örn: kira hesabı yapan program 

            //Başlangıç yılı 2006
            //    Btiş yılı 2022
            //    Kirası 1000
            //    artış miktarı %15

            int yl = 2006;
            float kira = 1000;
            float artis = 1.15f;


            while (yl < 2022)
            {
                yl++;
                kira *= artis;
                Console.WriteLine(yl + " yılındaki kira bedeli : " + kira);
            }

            Console.ReadLine();

        }
    }
}