using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2403_03
{
    class Program
    {
        static int fatura = 0;
        static void Kiyafetsec(int secim)
        {
            if (secim == 1)
            {
                Console.WriteLine("Etek fiyatı : " + 100);
                fatura += 100;
            }
            else if (secim == 2)
            {
                Console.WriteLine("Gömlek fiyatı : " + 50);
                fatura += 50;
            }
        }

        static void Aksesuar(string marka, int kampanya)
        {
            if (marka == "swatch" && kampanya > 10 && kampanya < 20)
            {
                Console.WriteLine("swatch marka saat");
                fatura += 1000;
                fatura -= kampanya;
            }
        }
        static void FaturaOde()
        {
            Console.Write("Ödemeniz gereken tutar : " + fatura);
        }
        static void Main(string[] args)
        {
            int secim;
            do
            {
                Console.WriteLine("1-etek seçiniz");
                Console.WriteLine("2-gömlek seçiniz");
                Console.WriteLine("3-aksesuar seçiniz");
                Console.WriteLine("4-hesap öde");

                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Kiyafetsec(secim);
                        break;
                    case 2:
                        Kiyafetsec(secim);
                        break;
                    case 3:
                        Console.WriteLine("marka giriniz");
                        string marka = Console.ReadLine();
                        Console.WriteLine("kampanya tutarı giriniz.");
                        int kampanya = Convert.ToInt32(Console.ReadLine());
                        Aksesuar(marka, kampanya);
                        break;
                    case 4:
                        FaturaOde();
                        break;
                }
            }
            while (secim != 4);
            Console.ReadLine();
        }
    }
}