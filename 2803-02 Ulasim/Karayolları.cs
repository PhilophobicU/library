using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_02
{
    class Karayolları:Ulasim
    {
        string plakano;
        int tursayisi;
        string soforadi;
        string seferaraliği;
        public string PlakaNO
        {
            get { return plakano; }
            set { plakano = value; }
        }
        public int TurSayisi
        {
            get { return tursayisi; }
            set { tursayisi = value; }
        }
        public string Soforadi
        {
            get { return soforadi; }
            set { soforadi = value; }
        }
        public string SeferAraligi
        {
            get { return seferaraliği; }
            set { seferaraliği = value; }
        }
        void ky(char rezervasyon, string seferadi, int biletfiyati)
        {
            if (rezervasyon == 'e' || rezervasyon == 'E')
            {
                Console.WriteLine(Sehiricdis + " Rezervasyon yapılmıştır.");
                Console.WriteLine("Ödemeniz gereken tutar : "+biletfiyati);
                Console.WriteLine("Sefer adınız : "+seferadi);
            }
            Console.ReadLine();
        }
    }
}
