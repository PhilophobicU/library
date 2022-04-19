using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cinsiyetinizi giriniz <E/K>");
            char cinsiyet = Convert.ToChar(Console.ReadLine());
           
            Console.WriteLine("Hediye çekiniz var mı?<true/false>");
            bool cek = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("Çek tutarınızı giriniz");
            float cektutar = Convert.ToSingle(Console.ReadLine());
            
            //her veri tipinin karşılığı var cts (common type system)
            //int ---->toint32
            //string ----> toString
            //char --->Tochar
            //double --->toDouble
            //Bool ----> toBoolean
            //float ---->ToSingle
        }
    }
}