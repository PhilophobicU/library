using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2303_11
{
    class Program
    {
        private static void Kurlar(int tl)
        {
            

            int dolar = tl / 13;
            int euro = tl / 15;
            int sterlin = tl / 20;
            int altin = tl / 1000;

           
            Console.WriteLine("{0} değerindeki paranızın // {1} dolar karşılığı // {2} euro karşılığı // {3} sterlin karşılığı // {4} altin karsiligi // ",tl,dolar,euro,sterlin,altin);
            
        }

        static void Main(string[] args)
        {
            // para birimine göre kur hesabı yapan program 
            Console.WriteLine("Tl yi çıkra");
            int tl = Convert.ToInt32(Console.ReadLine());

            Kurlar(tl);
            
            
            
            

            
            Console.ReadLine();

        }



    }
}