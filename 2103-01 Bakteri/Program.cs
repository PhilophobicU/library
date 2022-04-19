using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir bakteri cinsşi her 4dakikada bir ikiye bölünerek çoğalmaktadır başlangıçta bir bakteri olduğunu kabul ederek bir saat sonra oluşacak bakteri sayısını bulunuz
            
            int sayac = 0;
            for (int i = 1; sayac < 61; i *= 2)
            {
                Console.WriteLine("bakteri = " + i);
                sayac += 4;
                Console.WriteLine("sayac =" + sayac);
            }
            Console.ReadLine();
        }
    }
}