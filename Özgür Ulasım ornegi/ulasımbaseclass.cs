using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasım_ornegi
{
    public class ulasımbaseclass
    {

        public void ANASAYFA()
        {

            Console.WriteLine("Ulasım hizmetleri anasayfasına hosgeldınız...");
            Console.WriteLine("a-Hava Yolları");
            Console.WriteLine("b-Kara Yolları");
            Console.WriteLine("c-Demir Yolları");
            Console.WriteLine("d-Deniz Yolları");
            Console.WriteLine("Lutfen bir secim yapınız.");
            string anamenüsecim=Console.ReadLine();
            switch (anamenüsecim)
            {
                case "a":
                    heryerdeaynı();

                    
                    break;
                    case "b":
                    heryerdeaynı();
                    break;

                case "c":
                    heryerdeaynı();
                    break;

                        case "d":
                    heryerdeaynı();
                    break;
                default:
                    break;
            }



        }

        public double duraksayisi;
        private int koltuknumarası;
        private string koltukonum;
        private double biletfiyatı; //(dureka bası fıyat)
        private string rezervasyon;
        private string durakbilgisi;
        private string durakadları;

        public int Koltuknumarasi
        {
            get { return koltuknumarası; }

            set { koltuknumarası = value; }
        
        }
        public string Koltukkonum
        {
            get { return koltukonum; }
            set
            {
                if ("kuzey"==value.ToLower())
                {
                     koltukonum=value;
                }
                else if("güney"== value.ToLower())
                {
                    Console.WriteLine("Güney yonunde rezervasyon yapılamamaktadır.");
                }
                
            
            }
        
        }

        public double Biletfiyat
        {
            get { return biletfiyatı; }
            set { biletfiyatı = value; }
        }

        public string Rezervasyon
        {
            get { return rezervasyon; }
            set { rezervasyon= value; }
        
        }

        public string Durakbilgisi
        {
            get { return durakbilgisi; }
            set
            {
                if ("cevizlibağ"==value.ToLower())
                {
                    Console.WriteLine("Cevizlibağ durağına hizmet verilememektedir.");
                }

                else
                {
                    durakbilgisi=value; 
                }
            
            }

           
        }



        public string Durakadları
        {
            get { return durakadları; }
            set
            {
                durakadları=value;

            }


        }


        public double Fiyathesabı(double durakbasıfiyat, double durakadeti)
        {
            
            double fatura = Biletfiyat * durakadeti;

            return fatura;
        }


        public void Ulasımektra(string koltukkonum, int rezervasyon)
        {

            Console.WriteLine(koltukkonum+" numaralı koltugunuz "+rezervasyon+"konumunda yapılmıstır.");
        
        
        }




        public void heryerdeaynı()
        {

            Console.WriteLine("Lutfen bir koltuk numarası giriniz:");
            Koltuknumarasi = Convert.ToInt32(Console.ReadLine());

            koltukkonumagit:
            try                                                                        //try and cathc calısmıyor cunku anasayfa metodunu ıcınde olmalıydı.
            {
                Console.WriteLine("Lutfen bir koltuk konumu giriniz:");
                Koltukkonum = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Lutfen gecerli bir konum giriniz:");
                goto koltukkonumagit;
            }

            Console.WriteLine("Durak bası fiyat giriniz:");
            Biletfiyat=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rezervasyonunuz var mı?:");
            Rezervasyon=Console.ReadLine();
            Console.WriteLine("Gitmek istediğiniz durak bilgisini(adını giriniz servis durumu icin) giriniz:");
            Durakbilgisi=Console.ReadLine();
            Console.WriteLine("Durak adini giriniz");
            Durakadları=Console.ReadLine();
            Console.WriteLine("Kaç durak gitmek istiyorsunuz:");
            duraksayisi=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ödemeniz gerken ücret:"+Fiyathesabı(Biletfiyat, duraksayisi));
            Ulasımektra(Koltukkonum,Koltuknumarasi);





        }
    }
}
