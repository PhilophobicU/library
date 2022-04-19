using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_02
{
    class Ulasim
    { 
        int koltukNumarasi;//
        string koltukKonum;//
        double biletFiyati;//
        char rezervasyon;
        string durakBilgisi;//
        string durakAdlari;
        double fiyat;//
        double durakSayisi;//
        string sehiricdis;
       
        public void Istek()
        {
            Console.Write("Lütfen kaç durak gideceğinizi giriniz : ");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Koltuk numaranızı giriniz : ");
            koltukNumarasi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Koltuk konumunuzu giriniz : ");
            koltukKonum = Console.ReadLine();
            Console.Write("Lütfen durak bilgisi giriniz : ");
            durakBilgisi = Console.ReadLine();
            Console.Write("Lütfen durak sayısını giriniz : ");
            durakSayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen sefer adınızı belirtin : ");
            sehiricdis = Console.ReadLine();


        }

        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        private double BiletFiyatHesap(double fiyat, double durakSayisi)
        {
            biletFiyati = fiyat * durakSayisi;
            return biletFiyati;
        }
        public string Sehiricdis
        {
            get { return sehiricdis; }
            set
            {
                if (value == "Şehirdışı")
                {
                    biletFiyati *= 1.08;
                }
                else if (value == "Şehiriçi")
                {
                    biletFiyati *= 1.03;
                }
                else
                {
                    biletFiyati *= 1.1;
                }
            }
        }
        public string DurakAdlari
        {
            get { return durakAdlari; }
            set { durakAdlari = value; }
        }
        public char Rezervasyon
        {
            get { return rezervasyon; }
            set
            {
                Console.WriteLine("Rezervasyon istiyor musunuz <e/h>?");
                char cevap = Convert.ToChar(Console.ReadLine());
                if (cevap == 'e' || cevap == 'E')
                {
                    { rezervasyon = value; }
                }
                else
                {
                    Console.WriteLine("Rezervasyon iptal edilmiştir.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
        public double DurakSayisi
        {
            get { return durakSayisi; }
            set { durakSayisi = value; }
        }
        
        public string DurakBilgisi
        {
            get { return durakBilgisi; }
            set
            {
                if (value == "AyrılıkÇeşmesi" && value == "açeşme")
                {
                    Console.WriteLine("Başarılı");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Başarısız.");
                    Console.ReadLine();
                }
            }
        }
       
        public int KoltukNumarasi
        {
            get { return koltukNumarasi; }
            set { koltukNumarasi = value; }
        }
        public string KoltukKonum
        {
            get { return koltukKonum; }
            set
            {
                if (value == "Kuzey")
                {
                    { koltukKonum = value; }
                    Console.WriteLine("Rezervasyonunuz başarıyla oluşturulmuştur.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bu rezervasyon oluşturulamaz.");
                    Console.ReadLine();
                }
            }
        }
        
        public void UlasimEkstra(int koltukKonum,string rezervason)
        {

        }
       
    }
}
