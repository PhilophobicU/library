using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulasim ulas1 = new Ulasim();
            Console.WriteLine("Lütfen Ulaşım tipinizi seçiniz.");

            Console.WriteLine();
            Console.WriteLine("A- Hava Yolları");
            Console.WriteLine("B- Kara Yolları");
            Console.WriteLine("C- Demir Yolları");
            Console.WriteLine("D- Deniz Yolları");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Hava Yollarını seçtiniz.");
                    ulas1.Istek();
                    break;
                case 2:
                    Console.WriteLine("Kara Yollarını seçtiniz.");
                    ulas1.Istek();
                    break;
                case 3:
                    Console.WriteLine("Demir Yollarını seçtiniz.");
                    ulas1.Istek();
                    break;
                case 4:
                    Console.WriteLine("Deniz Yollarını seçtiniz.");
                    ulas1.Istek();
                    break;
            }










        }
    }
}
//ulasim base class
// a havayollari
// b karayolları
//c demir yolları
//d deniz yolları
//bunları birer subclass hale getir

// ulaşım içerisinde
// koltuk numarası
//koltuk konum
// bilet fiyatı 
// rezervasyon
// durak bilgisi 
// durak adları
// hepsi kapsülleme
//bilet fiyatı hesapla metodu returl fiyat * duraksayısı
//ulaşımekstra koltuk konum rezervasyon >>> voidli metod kuzeyse rezervasyon var güneyse yok 