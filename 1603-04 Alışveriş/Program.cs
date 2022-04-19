using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603_4
{
    class Program
    {
        static void Main(string[] args)
        {
        basagit:
            Console.WriteLine("******öz Waikiki*****");
            Console.WriteLine("1-Bayan");
            Console.WriteLine("2-Bay");
            Console.WriteLine("3-Çocuk");
            Console.WriteLine("Seçin Yapınız");

            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Bayan Giyim Ürünleri Seçiniz");
                    Console.WriteLine("İç giyim");
                    Console.WriteLine("Dış giyim");
                    string secenek = Console.ReadLine();
                    if (secenek == "İç giyim")
                    {
                        Console.WriteLine("fiyat giriniz");
                        float fiyat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("indirim fiyatı giriniz");
                        float indirim = Convert.ToSingle(Console.ReadLine());
                        fiyat -= indirim; //fiyat = fiyat-indirim
                        Console.WriteLine("Ödemeniz gereken tutar:" + fiyat);
                    }
                    else
                    {
                        Console.WriteLine("a-Ayakkabı");
                        Console.WriteLine("b-Çanta");
                        char sec = Convert.ToChar(Console.ReadLine());
                        switch (sec)
                        {
                            case 'a':
                                Console.WriteLine("İnci ayakkabılarda indirim var");
                                Console.WriteLine("marka seçiniz");
                                string marka = Console.ReadLine();
                                if (marka == "inci" || marka == "kemal tanca")
                                {
                                    Console.WriteLine("Tebrikler %25 indirim Kazandınız Hemen ALLL");
                                    Console.WriteLine("Ayakkabı fiyatı giriniz");
                                    float fiyat = Convert.ToSingle(Console.ReadLine());
                                    fiyat -= fiyat * 25 / 100;
                                    Console.WriteLine("Ödemenizgereken tutar " + fiyat);
                                }
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Bay Giyim Ürünleri Seçiniz");
                    Console.WriteLine("Giysi");
                    Console.WriteLine("Aksesuar");
                    string secenek2 = Console.ReadLine();
                    if (secenek2 == "Giysi")
                    {
                        Console.WriteLine("Lütfen alışveriş yapmak isteidğiniz ürün tipini seçin");
                        Console.WriteLine("a-Hoodie");
                        Console.WriteLine("b-Pantolon");
                        Console.WriteLine("c-Shirt");
                        char sec2 = Convert.ToChar(Console.ReadLine());
                        switch (sec2)
                        {
                            case 'a':
                                Console.WriteLine("Lütfen almak istediğiniz hoodie rengini seçiniz");
                                Console.WriteLine("a-Kırmızı");
                                Console.WriteLine("b-Siyah");
                                char renk = Convert.ToChar(Console.ReadLine());
                                if (renk == 'a')
                                {
                                    Console.WriteLine("Kırmızı rengi istediğinizi onaylıyor musunuz?");
                                    char onay = Convert.ToChar(Console.ReadLine());
                                    if (onay == 'e' || onay == 'E')
                                    {
                                        Console.WriteLine("Lütfen fiyat giriniz");
                                        int hd = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Tebrikler " + renk + " hoodieyi " + hd + " fiyata aldınız");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Siyah rengi istediğinizi onaylıyor musunuz?");
                                    char onay = Convert.ToChar(Console.ReadLine());
                                    if (onay == 'e' || onay == 'E')
                                    {
                                        Console.WriteLine("Lütfen fiyat giriniz");
                                        int hd = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Tebrikler " + renk + " hoodieyi " + hd + " fiyata aldınız");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Onay vermediğiniz için işleminiz iptal edildi");
                                    }
                                }
                                break;

                            case 'b':
                                Console.WriteLine("Lütfen almak istediğiniz pantolon rengini seçiniz");
                                Console.WriteLine("a-Gri");
                                Console.WriteLine("b-Siyah");
                                char renkt = Convert.ToChar(Console.ReadLine());
                                if (renkt == 'b')
                                {
                                    Console.WriteLine("Siyah rengi istediğinizi onaylıyor musunuz?");
                                    char onay = Convert.ToChar(Console.ReadLine());
                                    if (onay == 'e' || onay == 'E')
                                    {
                                        Console.WriteLine("Lütfen fiyat giriniz");
                                        int hd = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Tebrikler " + renkt + " pontolonu " + hd + " fiyata aldınız");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Gri rengi istediğinizi onaylıyor musunuz?");
                                    char onay = Convert.ToChar(Console.ReadLine());
                                    if (onay == 'e' || onay == 'E')
                                    {
                                        Console.WriteLine("Lütfen fiyat giriniz");
                                        int hd = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Tebrikler " + renkt + " pantolonu " + hd + " fiyata aldınız");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Onay vermediğiniz için işleminiz iptal edildi");
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Çocuk Giyim Ürünleri Seçiniz");
                    break;
                default:
                    Console.WriteLine("Böyle bir seçim yok...");

                    break;
            }
            Console.WriteLine("Alışverişe devam etmek ister misiniz?");
            char islem2 = Convert.ToChar(Console.ReadLine());
            if (islem2 == 'E' || islem2 == 'e')
            {
                goto basagit;
            }
            else
            {
                Console.WriteLine("Yine bekleriz...");
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
    }
}
