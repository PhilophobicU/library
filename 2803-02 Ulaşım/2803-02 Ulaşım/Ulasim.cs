using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_02_Ulaşım
{
    internal class Ulasim
    {
        string isimsoyisim;
        int koltuknumara;
        double biletfiyati;
        char rezervasyon;
        public string[] duraklar = new string[14] { "1- Kadıköy", "2- Hamza Yerlikaya", "3- Ayrılık Çeşmesi", "4- Haydarpaşa", "5- Numune Hastanesi", "6- Karacaahmet", "7- Zeynep Kamil", "8- Askerlik şubesi", "9- Pazarbaşı", "10- Marmara ünv.", "11- Fıstıkağacı", "12- Setbaşı", "13- Horhor", "14- Marmaray" };
        double durakbasi = 5;
        double kmbasi = 2;
        double duraksayisi;
        
        string firmaadi;
        string sefergunu;
        int motorsayisi;
        double bagajfiyati = 10;
        double bagajkg;
        double bagajtoplam;
        int seferkalite;
        int ucuskm;

        public int Ucuskm
        {
            get { return ucuskm; }
            set { ucuskm = value; }
        }
        public int SeferKalite
        {
            get { return seferkalite; }
            set { seferkalite = value; }
        }
        public double BagajFiyati
        {
            get { return bagajfiyati; }
            set { bagajfiyati = value; }
        }


        public double BagajToplam
        {
            get { return bagajtoplam; }
            set { bagajtoplam = value; }
        }
        public string SeferGunu
        {
            get { return sefergunu; }
            set { sefergunu = value; }
        }
        public int MotorSayisi
        {
            get { return motorsayisi; }
            set { motorsayisi = value; }
        }
        public double BagajKg
        {
            get { return bagajkg; }
            set { bagajkg = value; }
        }
        public string FirmaAdi
        {
            get { return firmaadi; }
            set { firmaadi = value; }  
        }







        /// <summary>
        /// /////////////////////////////////////////
        /// </summary>

        public double BiletFiyatHesap()
        {
            biletfiyati = duraksayisi * durakbasi;
            return biletfiyati;
        }
       public double UcakBiletFiyatHesap()
        {
            biletfiyati = ucuskm * kmbasi;
            return biletfiyati;
        }
        public double DurakSayisi
        {
            get { return duraksayisi; }
            set
            {
                if (value < 15 && value >0)
                {
                    { duraksayisi = value; }
                }
                else
                {
                    Console.WriteLine("Durak sayısını yanlış girdiğiniz için işleme devam edemezsiniz.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
        public int KoltukNumara
        {
            get { return koltuknumara;}
            set
            {
                if (value <= 0 || value >= 48)
                {
                    Console.WriteLine("Böyle bir koltuk bulunmamaktadır.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    { koltuknumara = value; }
                }
            }
        }
        public double Durakbasi
        {
            get { return durakbasi; }
            set { durakbasi = value; }
        }
        public string IsımSoyisim
        {
            get { return isimsoyisim; }
            set { isimsoyisim = value; }
        }
        public char Rezervasyon
        {
            get { return rezervasyon; }
            set { rezervasyon = value; }
        }
        public void Anasayfa()
        {
            Karayolları kara = new Karayolları();
            Havayollari hava = new Havayollari();
            Console.WriteLine("Lütfen ulaşım tipinizi seçiniz.");
            Console.WriteLine();
            Console.WriteLine("1- Hava Yolları");
            Console.WriteLine("2- Kara Yolları");
            Console.WriteLine("3- Demir Yolları");
            Console.WriteLine("4- Deniz Yolları");
            Console.WriteLine();
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Hava yollarını seçtiniz");
                    hava.HavaYollariSorular();
                    break;
                case 2:
                    Console.WriteLine("Kara yollarını seçtiniz");
                    kara.KaraYollariSorular();
                    
                    break;
                case 3:
                    Console.WriteLine("Demir yollarını seçtiniz");
                    break;
                case 4:
                    Console.WriteLine("Deniz yollarını seçtiniz");
                    break;
            }
        }
        
        
        void DemirYollariSorular()
        {

        }
        void DenizYollariSorular()
        {

        }
       
        
    }
}
