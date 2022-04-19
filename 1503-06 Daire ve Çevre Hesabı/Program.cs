using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dairenin alan ve çevresi

            Console.WriteLine("Daire yarı çapını giriniz");

            float yaricap = Convert.ToSingle(Console.ReadLine());
            float pi = 3.14f;
            float alanhesabi = yaricap * yaricap * pi;
            float cevrehesabi = 2 * pi * yaricap;
            
            Console.WriteLine("Alan : " + alanhesabi);
            Console.WriteLine("Çevre : " + cevrehesabi);

            Console.ReadLine();
        }
    }
}