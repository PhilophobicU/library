using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2403_04
{
    class Program
    {
        static int fatura = 0;
        static void Yemeksec(int secim2)
        {
            Console.Write("1- Et yemeği , 2- Mantı ,3- Tavuk");
            secim2 = Convert.ToInt32(Console.ReadLine());
            if (secim2 == 1)
            {
                Console.WriteLine("Et fiyatı 60 Tl");
                fatura += 60;
            }
            else if (secim2 == 2)
            {
                Console.WriteLine("Mantı fiyatı 45 Tl");
                fatura += 45;
            }
            else if (secim2 == 3)
            {
                Console.WriteLine("Et fiyatı 40 Tl");
                fatura += 40;
            }

        }
        static void Iceceksec(int secim2)
        {

            Console.Write("1- Ayran , 2- Kola ,3- Limonata");
            secim2 = Convert.ToInt32(Console.ReadLine());
            if (secim2 == 1)
            {
                Console.WriteLine("Ayran fiyatı 6 Tl");
                fatura += 6;
            }
            else if (secim2 == 2)
            {
                Console.WriteLine("Kola fiyatı 9 Tl");
                fatura += 9;
            }
            else if (secim2 == 3)
            {
                Console.WriteLine("Limonata fiyatı 40 Tl");
                fatura += 12;
            }
        }
        static void Tatlisec(int secim2)
        {

            Console.Write("1- Kazandibi , 2- Tiramisu ,3- Yas pasta");
            secim2 = Convert.ToInt32(Console.ReadLine());
            if (secim2 == 1)
            {
                Console.WriteLine("Kazandibi fiyatı 15 Tl");
                fatura += 15;
            }
            else if (secim2 == 2)
            {
                Console.WriteLine("Tiramisu fiyatı 25 Tl");
                fatura += 25;
            }
            else if (secim2 == 3)
            {
                Console.WriteLine("Yas pasta fiyatı 27 Tl");
                fatura += 27;
            }
        }
        static void FaturaOde()
        {
            Console.Write("Ödemeniz gereken tutar : " + fatura);
        }
        static void Main(string[] args)
        {
            Console.Clear();
            int secim;
            int secim2;
            do
            {
                Console.WriteLine("1-yiyecek seçiniz");
                Console.WriteLine("2-içecek seçiniz");
                Console.WriteLine("3-tatlı seçiniz");
                Console.WriteLine("4-fatura öde");

                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Yemeksec(secim);
                        break;
                    case 2:
                        Iceceksec(secim);
                        break;
                    case 3:

                        Tatlisec(secim);
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