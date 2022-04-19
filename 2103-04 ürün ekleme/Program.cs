using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menüden seçim yapınız.");
            Console.WriteLine("1- Ürün Ekle");
            Console.WriteLine("2- Zam yap");

            char sec = Convert.ToChar(Console.ReadLine());
            float toplamfiyat = 0f;
            float vergilifiyat = 0f;
            Random random = new Random();

            switch (sec)
            {
                case ('1'):

                    Console.WriteLine("Kaç ürün eklemek istiyorsunuz ?");
                    int adet = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= adet; i++)
                    {
                        Console.WriteLine("Ürün Fiyatı giriniz");
                        float fiyat = Convert.ToSingle(Console.ReadLine());
                        toplamfiyat += fiyat;
                        if (fiyat < 100)
                        {
                            vergilifiyat += (fiyat + random.Next(20, 30));
                            Console.WriteLine("1. kod blo");
                        }

                        else if (fiyat < 999 && fiyat >= 100)
                        {
                            vergilifiyat += (fiyat + random.Next(50, 60));
                            Console.WriteLine("2. kod blo");
                        }

                        else
                        {
                            vergilifiyat += (fiyat + random.Next(100, 200));
                            Console.WriteLine("3. kod blo");
                        }


                    }
                    Console.WriteLine("Vergili Toplam = " + vergilifiyat);
                    Console.WriteLine("Toplam fiyat = " + toplamfiyat);
                    float verg = vergilifiyat - toplamfiyat;
                    Console.WriteLine("Vergi Miktarı =" + verg);
                    Console.ReadLine();




                    break;

                case ('2'):

                    break;
            }
        }
    }
}
//ürün ekle kaç tane eklemek istiyorsanız kaç tane giriceğini yaz döngüyü 5e kur koşulbizde toplam fiyat toplam vergili fiyat yazdır