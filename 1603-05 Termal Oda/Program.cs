using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //otel seç

            //kral odası standar ekonik oda vip oda 3 toplamda fiyat 150   75 100
            //özellik seçini 
            //sauna 2özel havuz    s ise kalacak kişi sayısı 2dden fazla ve 8den az ise %7,5 indirim %2 ötv alınacak. kalcak kişi ve ghün çarp günlük ücretle çarp sonra indirim ve ötvyi hesaplat
           
            int kralfiyat = 150;
            int standart = 75;
            int vipoda = 100;





            Console.WriteLine("Lütfen kalacak kişi sayısını belirtiniz.");
            int kks = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Kalacağınız gün sayısını giriniz");
            int kgs = Convert.ToInt32(Console.ReadLine());

            int kraltoplam = kks * kralfiyat * kgs;
            int standartplm = kks * standart * kgs;
            int viptplm = kks * vipoda * kgs;

            float hazirandrim = (standartplm * -0.04f);
            float hazirankdv = (standartplm * 0.08f);
            float haziranfiyat = standartplm + hazirandrim + hazirankdv;

            float temmuzkdv = standartplm * 0.18f;
            float temmuzotv = standartplm * 0.025f;
            float temmuzfiyat = standartplm + temmuzotv + temmuzkdv;

            float agustoskdv = standartplm * 0.08f;
            float agustosotv = standartplm * 0.025f;
            float agustoszam = standartplm * 0.1f;
            float agustosfiyat = standartplm + agustoskdv + agustosotv + agustoszam;

            float ndrim = kraltoplam * 0.075f;
            float ötv = kraltoplam * 0.02f;
            float ödeme = -ndrim + ötv + kraltoplam;

            float ötherm = (0.025f + 0.085f) * ödeme + ödeme;



            Console.WriteLine("Lütfen oteli seçiniz");
            Console.WriteLine("A Oteli");
            Console.WriteLine("B Oteli");
            Console.WriteLine("C Oteli");
            string otel = Console.ReadLine();
            switch (otel)
            {
                case ("A Oteli"):
                    Console.WriteLine("A otelimize hoşgeldiniz.. Lütfen oda seçimi yapınız");
                    Console.WriteLine("Kral Odası");
                    Console.WriteLine("Standart Oda");
                    Console.WriteLine("Vip Oda");
                    string oda = Console.ReadLine();
                    if (oda == "Kral Odası")
                    {

                        Console.WriteLine("Özellik seçiniz");
                        Console.WriteLine("Sauna");
                        Console.WriteLine("Özel Havuz");
                        string ozel = Console.ReadLine();

                        if (ozel == "Sauna")
                        {
                            Console.WriteLine("sauna seçtiniz");
                            if (kks > 2 || kks < 8)
                            {
                                Console.WriteLine("Sauna");
                                Console.WriteLine("İndirimsiz hali:" + kraltoplam);
                                Console.WriteLine("Ödemeniz gereken tutar : " + ödeme);
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Özel Havuz");
                            Console.WriteLine("Termal kaynaklardan yararlanmak ister misiniz?");
                            char termal = Convert.ToChar(Console.ReadLine());
                            if (termal == 'e' || termal == 'E')
                            {
                                Console.WriteLine("Ödemeniz gereken tutar : " + ötherm);
                                Console.ReadLine();
                            }
                            else
                            {
                                float termalsiz = 0.075f;
                                float termalsizödm = (termalsiz * ödeme) + ödeme;

                                Console.WriteLine("Ödemeniz gereken tutar :" + termalsizödm);
                                Console.ReadLine();
                            }
                        }
                    }

                    break;
                case ("B Oteli"):
                    Console.WriteLine("Rezervasyon yapmak ister misiniz?");
                    char cevap = Convert.ToChar(Console.ReadLine());
                    if (cevap == 'e' || cevap == 'E')
                    {
                        Console.WriteLine("Lütfen ay belirtiniz.");
                        Console.WriteLine("h-haziran");
                        Console.WriteLine("t-temmuz");
                        Console.WriteLine("a-ağustos");
                        char ay = Convert.ToChar(Console.ReadLine());
                        switch (ay)
                        {
                            case 'h':
                                Console.WriteLine("Ödemeniz gereken tutar : " + haziranfiyat);
                                Console.ReadLine();
                                break;
                            case 't':
                                Console.WriteLine("Ödemeniz gereken tutar : " + temmuzfiyat);
                                Console.ReadLine();
                                break;
                            case 'a':
                                Console.WriteLine("Ödemeniz gereken tutar : " + agustosfiyat);
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("yanlış giriş yaptınız");
                                break;

                        }

                    }
                    break;
                case ("C Oteli"):

                    break;
                    Console.ReadLine();
            }
        }
    }
}
//