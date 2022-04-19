using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //rastgele değer atama random
            Random rasthele = new Random();
            int sayi = rasthele.Next(10, 101); // 10 ile 100 arasında rastgele değer ataması  Başlangıcı 10 ama bitişi 101 değil 10 ile 100 arasında
            int sayi2 = rasthele.Next(100, 201);

            Console.WriteLine("Rastgele sayi değeriniz : " + sayi);
            Console.WriteLine("Rastgele sayi değeriniz 2. : " + sayi2);
            Console.ReadLine();
        }
    }
}