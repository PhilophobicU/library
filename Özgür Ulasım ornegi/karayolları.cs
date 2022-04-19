using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulasım_ornegi
{
    internal class karayolları:ulasımbaseclass
    {

        private string plakano;
        private string seferadi;
        private string seferaraligi;
        private double tursayisi;




        public void Karayollarıaltsayfa()
        {
            Console.WriteLine("Plaka noyu giriniz");
            Plakano = Console.ReadLine();
            Console.WriteLine("Tur sayısını giriniz:");
            Tursayisi=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sefer adını gırınız:");
            Seferadı=Console.ReadLine();
            Console.WriteLine("Sefer aralıgınız giriniz:");
            Seferaraligi=Console.ReadLine();
            

            

        
        
        
        }

        public string Plakano
        { 
          get { return plakano; }

            set
            {
                if (value.Length==6)
                {
                    plakano = value;


                }
                else
                {
                    Console.WriteLine("Plaka degeri 6 haneli olmalıdır.");
                }
            
            
            }
                   
                
               

        
        
        }

        private string Seferadı
        {
            get { return seferadi; }
            set { seferadi = value; }
        }

        public string Seferaraligi
        { get { return seferaraligi; } set { seferaraligi = value; } 
        
        }
        public double Tursayisi
        { 
         get { return tursayisi;} 
            set { tursayisi = value; }  
        
        }




        public void Ky(string rezervasyon, string seferadi, double biletfiyat)
        {
            if (rezervasyon.ToLower() == "evet" && seferadi.ToLower() == "sehir dısı")
            {
                double sonuc = biletfiyat * 1.08;

                Console.WriteLine(seferadi + " hattına " + sonuc + " lira ücret ile rezervasyonunuz yapılmıstır.");
            }


            else if (rezervasyon.ToLower() == "evet" && seferadi.ToLower() == "sehir ici")
            {

                double sonuc = biletfiyat * 1.03;

                Console.WriteLine(seferadi + " hattına " + sonuc + " lira ücret ile rezervasyonunuz yapılmıstır.");



            }

            else
            {
                double sonuc=biletfiyat*1.1;
                Console.WriteLine(seferadi + " hattına " + sonuc + " lira ücret ile isleminiz yapılmıstır.");
            }


            
        
        }




    }
}
