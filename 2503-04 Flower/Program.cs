using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // hata yakalama komutları
            // try ----> kod yaz hata var mı yok mu kontrol et 
            // catch-----< yakala eğer tryda hata oluştu ise cartch otomatik hatayı bulur yakalar
            //finally her iki durumdada en son irmesini istediğimiz alandır yazılması şart değildir.

            //throw kendi hatamızı kendimiz yazmak istersek throw komutunu kullanırız.
            // iki türlü hata yakalama durumu vardır
            // runtime çalışma zamanı hataları (float yerine int irildiğinde)
            // syntax hataları kod yazarken uralların dışında oluşan hatalara denir.

            
                git:
                Console.WriteLine("1- Düğün çiçeği");
                Console.WriteLine("2- Cenaze çiçeği");
                int secenek = Convert.ToInt32(Console.ReadLine());

                if (secenek == 1)
                {
                    try
                    {
                    Flower cicek1 = new Flower();
                    Console.WriteLine("çiçek adı giriniz");
                    cicek1.cicekadi = Console.ReadLine();
                    Console.WriteLine("renk giriniz");
                    cicek1.renk = Console.ReadLine();
                    Console.WriteLine("Koku durumunu giriniz.");
                    cicek1.kokudurumu = Console.ReadLine();
                    Console.WriteLine("Fiyat Giriniz");
                    cicek1.fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adet giriniz");
                    cicek1.adet = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ödemeniz gereken tutar = " + cicek1.FiyatHesapla(cicek1.adet, cicek1.fiyat));
                    cicek1.Ozellik(cicek1.cicekadi, cicek1.renk);
                    Console.ReadLine();
                    }
                    catch
                    {
                    Console.WriteLine("Hata yakalandı işlem kontrol ediniz.");
                    goto git;
                    }
                }
                else if (secenek == 2)
                {
                try
                {
                    Flower cicek2 = new Flower();
                    Console.WriteLine("çiçek adı giriniz");
                    cicek2.cicekadi = Console.ReadLine();
                    Console.WriteLine("renk giriniz");
                    cicek2.renk = Console.ReadLine();
                    Console.WriteLine("Koku durumunu giriniz.");
                    cicek2.kokudurumu = Console.ReadLine();
                    Console.WriteLine("Fiyat Giriniz");
                    cicek2.fiyat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adet giriniz");
                    cicek2.adet = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ödemeniz gereken tutar = " + cicek2.FiyatHesapla(cicek2.adet, cicek2.fiyat));
                    cicek2.Ozellik(cicek2.cicekadi, cicek2.renk);
                    
                }
                catch
                {
                    Console.WriteLine("Hata yakalandı işlem kontrol ediniz.");
                    goto git;
                }
            }
                Console.ReadLine();
        }
            
    }
}

