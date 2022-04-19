using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termal_otel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kalacak kişi sayısını belirtin.");
            int kalacaksayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen kalınacak gün sayısını belirtin.");
            int kalinacakgun = Convert.ToInt32(Console.ReadLine());

            int kralfiyat = 150;
            int standartfiyat = 75;
            int vipodafiyat = 100;

            Console.WriteLine("Lütfen otelinizi seçin");
            Console.WriteLine("A Oteli");
            Console.WriteLine("B Oteli");
            Console.WriteLine("C Oteli");

            char otelsecimi = Convert.ToChar(Console.ReadLine());

            float kraltopfiyat = kralfiyat * kalacaksayi * kalinacakgun;
            float kampanya = kraltopfiyat * -0.075f;
            float kralotv = kraltopfiyat * 0.02f;
            float kralspali = kraltopfiyat + kralotv + kampanya;

            float thermalevet = kraltopfiyat * 0.025f;
            float thermalevettv = kraltopfiyat * 0.085f;
            float thermalevettplm = kraltopfiyat + thermalevet + thermalevettv;

            float thermalsiz = kraltopfiyat * 0.075f;
            float thermalsiztv = kraltopfiyat + thermalsiz;

            float standarttopfiyat = standartfiyat * kalacaksayi * kalinacakgun;
            float hazirandirim = standarttopfiyat * 0.04f;
            float hazirankdv = standarttopfiyat * 0.08f;
            float haziranodeme = standarttopfiyat + hazirankdv - hazirandirim;

            float temmuzkdv = standarttopfiyat * 0.18f;
            float temmuzotv = standarttopfiyat * 0.025f;
            float temmuzodeme = standarttopfiyat + temmuzotv + temmuzkdv;

            float agustoskdv = standarttopfiyat * 0.08f;
            float agustosotv = standarttopfiyat * 0.025f;
            float agustoszam = standarttopfiyat * 0.1f;
            float agustosodeme = standarttopfiyat + agustoskdv + agustoszam + agustosotv;

            float viptoplam = vipodafiyat * kalacaksayi * kalinacakgun;

            float vipmenu1 = viptoplam + 1000;
            float vipmenu2 = viptoplam + 1500;
            float altitaksit = viptoplam / 6;
            float sekiztaksit = viptoplam / 8;
            float onikitaksit = vipmenu2 / 12;
            float onikitaksitvade = onikitaksit + (onikitaksit * 0.02f);
            float onikitaksitodeme = onikitaksitvade * 12;



            switch (otelsecimi)
            {
                case ('a'):
                    Console.WriteLine("A Otelini seçtiniz.");
                    Console.WriteLine("A Otelimizdeki odalarımız");
                    Console.WriteLine("Kral Odası");
                    Console.WriteLine("Standart Oda");
                    Console.WriteLine("Vip Oda");
                    char odasecimi = Convert.ToChar(Console.ReadLine());

                    switch (odasecimi)
                    {
                        case 'a':
                            Console.WriteLine("Kral Odasını seçtiniz.");
                            Console.WriteLine("Lütfen kral odası için özellik seçin.");
                            Console.WriteLine("Sauna");
                            Console.WriteLine("Özel Havuz");
                            char odaozellik = Convert.ToChar(Console.ReadLine());
                            if (odaozellik == 'a')
                            {
                                Console.WriteLine("Sauna özelliğini seçtiniz.");
                                if (kalacaksayi > 2 || kalacaksayi < 8)
                                {
                                    Console.WriteLine("Tebrikler kampanyalı tutar kazandınız. Ödiyeceğiniz tutar : " + kralspali);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Ödiyeceğiniz tutar : " + kraltopfiyat);
                                }
                            }
                            else if (odaozellik == 'b')
                            {
                                Console.WriteLine("Özel havuz özelliğiniğini seçtiniz.");
                                Console.WriteLine("Termal kaynaklardan yararlanmak ister misiniz?<e/h>");
                                char thermalsecenek = Convert.ToChar(Console.ReadLine());
                                if (thermalsecenek == 'e' || thermalsecenek == 'E')
                                {
                                    Console.WriteLine("Termal seçenekli ve özel havuzlu odanızın değeri : " + thermalevettplm);
                                }
                                else
                                {
                                    Console.WriteLine("Özel havuzlu odanızın değeri : " + thermalsiztv);
                                }
                            }
                            break;
                        case 'b':
                            Console.WriteLine("Standart Odayı seçtiniz.");
                            Console.WriteLine("Rezervasyon yapmak ister misiniz?<e/h>");
                            char yanıt = Convert.ToChar(Console.ReadLine());
                            if (yanıt == 'e' || yanıt == 'E')
                            {
                                Console.WriteLine("Lütfen rezervasyon yapmak istediğiniz ayı seçiniz.");
                                Console.WriteLine("h-Haziran");
                                Console.WriteLine("t-Temmuz");
                                Console.WriteLine("a-Agustos");
                                char girdi = Convert.ToChar(Console.ReadLine());
                                switch (girdi)
                                {
                                    case 'h':
                                        Console.WriteLine("Haziran ayını seçtiniz.");
                                        Console.WriteLine("Temmuz ödemeniz : " + haziranodeme);
                                        break;
                                    case 't':
                                        Console.WriteLine("Temmuz ayını seçtiniz.");
                                        Console.WriteLine("Temmuz ödemeniz : " + temmuzodeme);
                                        break;
                                    case 'a':
                                        Console.WriteLine("Agustos ayını seçtiniz.");
                                        Console.WriteLine("Ağustos ödemeniz : " + agustosodeme);
                                        break;
                                    default:
                                        Console.WriteLine("Herhangi bir seçim yapmadınız.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Rezervasyonunuz iptal edilmiştir.");
                                Console.ReadLine();
                            }
                            break;

                        case 'c':
                            Console.WriteLine("Vip Odayı seçtiniz");
                            Console.WriteLine("Vip oda avantajlarımız");

                            Console.WriteLine("1- Açık büfe kahvaltı<e/h>");
                            char acikbüfe = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("2- Öğlen yemeği<e/h>");
                            char oglenyemek = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("3- Akşam yemeği<e/h>");
                            char vipsecenek = Convert.ToChar(Console.ReadLine());

                            if ((acikbüfe == 'e' || acikbüfe == 'E') && (oglenyemek == 'e' || oglenyemek == 'E') && (vipsecenek == 'h' || vipsecenek == 'H'))
                            {
                                Console.WriteLine("vip oda fiyat : " + viptoplam);

                                Console.WriteLine("vip menulu fiyat : " + vipmenu1);
                            }
                            else if ((acikbüfe == 'e' || acikbüfe == 'E') && (oglenyemek == 'e' || oglenyemek == 'E') && (vipsecenek == 'e' || vipsecenek == 'E'))
                            {
                                Console.WriteLine("vip oda fiyat : " + viptoplam);

                                Console.WriteLine("vip menulu fiyat : " + vipmenu2);
                                Console.WriteLine("Otel fiyatını taksit ister misiniz?<e/h>");
                                char yanıtfiyat = Convert.ToChar(Console.ReadLine());
                                if (yanıtfiyat == 'e' || yanıtfiyat == 'E')
                                {
                                    Console.WriteLine("Taksit seçeneklerimiz");
                                    Console.WriteLine("a-6 ay taksit");
                                    Console.WriteLine("b-8 ay taksit");
                                    Console.WriteLine("c-12 ay taksit");
                                    char taksitcevap = Convert.ToChar(Console.ReadLine());

                                    if (taksitcevap == 'a')
                                    {

                                        Console.WriteLine("Aylık ödemeniz : " + altitaksit);
                                    }
                                    else if (taksitcevap == 'b')
                                    {

                                        Console.WriteLine("Aylık ödemeniz : " + sekiztaksit);
                                    }
                                    else
                                    {

                                        Console.WriteLine("Aylık ödemeniz : " + onikitaksitvade);
                                        Console.WriteLine("Toplam ödemeniz : " + onikitaksitodeme);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Peşin ödemeyi seçtiniz");
                                    Console.ReadLine();
                                }
                            }
                            else if ((acikbüfe == 'h' || acikbüfe == 'H') && (oglenyemek == 'h' || oglenyemek == 'H') && (vipsecenek == 'h' || vipsecenek == 'H'))
                            {
                                Console.WriteLine("Menü seçimi yapmadınız.");
                            }
                            else
                            {
                                Console.WriteLine("Tek menü seçtiniz.");
                            }
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim yaptınız.");
                            break;
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}