using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //vize final not girilcek 40 60 girilcek topla 50 
            //büyük geçti küçük kaldı üt iste 50 büyük geçer yoksa kalır

            Console.WriteLine("Vize notunuzu giriniz");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz");
            int final = Convert.ToInt32(Console.ReadLine());

            float vizeort = vize * 0.40f;
            float finalort = final * 0.60f;
            float gecme = finalort + vizeort;

            if (gecme >= 50)
            {
                Console.WriteLine("Tebrikler" + gecme + "notu ile geçtiniz");
            }
            else
            {
                Console.WriteLine("Büt Notunuzu Giriniz");
                int but = Convert.ToInt32(Console.ReadLine());

                if (but >= 50)
                {
                    Console.WriteLine("Tebrikler geçtiniz");
                }
                else
                {
                    Console.WriteLine("Kaldınız");
                }
            }
            Console.ReadLine();
        }
    }
}