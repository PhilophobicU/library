using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_01
{
    class Program
    {
        //nethıd overloading (metotlara aşırı yükleme)
        //metto isimleri aynı fakat aldığı parametreler farklı olan metodlara method overloading denir.

        static void Topla(int a)
        {
            Console.WriteLine(" : degeri : "+a);
        }
        static void Topla(int z,int x)
        {
            int topla = z + x;
            Console.WriteLine("z ve x değerlerinin toplamı : "+topla);
        }
        static void Topla(double c, double f)
        {
            double topla = c + f;
            Console.WriteLine("c ve f nin toplamı : "+topla);
        }
        static void Main(string[] args)
        {
            Topla(10.2, 47.6);
            Topla(1, 5);
            Topla(8);
            Console.ReadLine();
        }
    }
}
