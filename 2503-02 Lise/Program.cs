using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_02
{
    class Program
    {
        static void NotHesap(double sinavbir, double sinaviki)
        {
           
            

            double hesap = (sinavbir + sinaviki) / 2;

            if (hesap > 50)
            {
                Console.WriteLine("Öğrenci geçti.");
            }
            else
            {
                Console.WriteLine("Öğrenci kaldı.");
            }

        }
        static void NotHesap(float sinavbirr, float sinavikii, float sozlu)
        {
           
            
            float hesap = (sozlu + sinavbirr + sinavikii) / 3;

            if (hesap > 50)
            {
                Console.WriteLine("Öğrenci geçti.");
            }
            else
            {
                Console.WriteLine("Öğrenci kaldı.");
            }

        }
        static void NotHesap(int sinavbirrr,int sinavikiii,int sozluu,int kanaat)
        {
           
            int hesap = (kanaat + sozluu + sinavbirrr + sinavikiii) / 4;

            if (hesap > 50)
            {
                Console.WriteLine("Öğrenci geçti.");
            }
            else
            {
                Console.WriteLine("Öğrenci kaldı.");
            }
            
        }
        static void Anasayfa()
        {
            Console.WriteLine("Lütfen hesaplama yapmak istediğiniz öğrenim düzeyini giriniz.");
            Console.WriteLine("1- İlkokul");
            Console.WriteLine("2- Ortaokul");
            Console.WriteLine("3- Lise");

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.Write("1. Sinav notunu giriniz : ");
                    double sinavbir = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sınav notunu giriniz : ");
                    double sinaviki = Convert.ToDouble(Console.ReadLine());
                    NotHesap(sinavbir, sinaviki);
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("1. Sinav notunu giriniz : ");
                    float sinavbirr = Convert.ToSingle(Console.ReadLine());
                    Console.Write("2. Sınav notunu giriniz : ");
                    float sinavikii = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Sözlü notunu giriniz : ");
                    float sozlu = Convert.ToSingle(Console.ReadLine());
                    NotHesap(sinavbirr, sinavikii, sozlu);
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("1. Sinav notunu giriniz : ");
                    int sinavbirrr = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sınav notunu giriniz : ");
                    int sinavikiii = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Sözlü notunu giriniz : ");
                    int sozluu = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kanaat notunu giriniz : ");
                    int kanaat = Convert.ToInt32(Console.ReadLine());
                    NotHesap(sinavbirrr, sinavikiii, sozluu, kanaat);
                    break;
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Anasayfa();

        }
    }
}
// switch case
//ilkokul               ortak metot not hesaplama
//ortaokul              ilkokul 1.sınav 2. sınav
//lise                  ortaokul 1. sınav 2. sınav 3.sözlü sınav
                        // lise 1. sınav 2. sınav ç sözlü sınav . kanaat

// tüm hepsi ortalama hesaplayıp kaldı geçti yapıcak