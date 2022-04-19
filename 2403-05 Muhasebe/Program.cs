using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2403_05
{
    class Program
    {
        static void Mesai()
        {
            Console.WriteLine("mesainiz var mı ?");
            string cevap = Console.ReadLine();
            if (cevap == "evet" || cevap == "Evet" || cevap == "EVET")
            {
                Console.WriteLine("mesai durumu : prim kazandınız");
            }
        }
        static void Muhasebe()
        {
            Console.WriteLine("Aylık Gelir");
            int gelir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aylık Gider");
            int gider = Convert.ToInt32(Console.ReadLine());
            int yillik = 12 * (gelir - gider);
            Console.WriteLine("Yıllık Kazancınız : " + yillik);
            Console.WriteLine();
            int bedel = gelir - gider;
            Console.WriteLine();
            Console.WriteLine("Çalışan sayınızı giriniz.");
            int calisan = Convert.ToInt32(Console.ReadLine());
            int yillikgelirgider = yillik * calisan;
            Console.Write("yillik calisan gider fiyatı : " + yillikgelirgider);

        }
        static void Deps()
        {
            Console.WriteLine("Departmanlar");
            Console.WriteLine("1- Muhasebe");
            Console.WriteLine("2- Teknik Servis");
            Console.WriteLine("3-İnsan Kaynakları");

            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Muhasebe();
                    Mesai();
                    break;
                case 2:
                    TeknikS();
                    break;
                case 3:
                    InsanKaynkak();
                    break;
            }
        }
        static void Main(string[] args)
        {
            // departmanlar 1muhaseb 2 teknik servis 3insan kaynakları // muhaseve metot mesai durumu çalışan sayısı metot
            //muhasebe
            //aylıkgelir 12000
            //aylık g,der 3000
            // yıllık kazanç
            // çalışan sayısı
            // yıllı çalışan gelir gider fiyatı
            //mesainiz var mı 

            Deps();


        }
    }
}
