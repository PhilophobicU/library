using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_02
{
    class Hava:Ulasim
    {
        string firmaadi;
        string seferyeri;
        string sefergunu;
        int motorsayisi;
        double bagajfiyati;
        double bagajkg;
        double bagtop;

        //hv returnl
        //firma adı pegasus ise motor sayısı 3ten fazla ise bilet fiyatına  %40 zam +kdv+%2ötv
        //firmadı onuair ise motor sayısı 3ten az az ise bilet fiyatına %30 kdv +4 ötv



        public double BagajTop()
        {
            bagtop = bagajkg * bagajfiyati;
            return bagtop;
        }
        public double Firmalar()
        {
            if (firmaadi == "pegasus" && motorsayisi >= 3)
            {
                bagtop *= 1.40;
                bagtop *= 1.18;
                bagtop *= 1.02;
                return bagtop;
            }
            else if (firmaadi == "onurair" && motorsayisi <= 3)
            {
                bagtop *= 1.30;
                bagtop *= 1.18;
                bagtop *= 1.04;
                return bagtop;
            }
            else
            {
                Console.WriteLine("Girdiğiniz bilgiler eşleşmemektedir.");
                Console.ReadLine();
                return 0;
            }

        }
        public void SeferBilgisi()
        {
            if (seferyeri == "anlatya" && (sefergunu == "çarşamba" || sefergunu == "cuma"))
            {
                Console.WriteLine("Uçuş bulunmamaktadır");
                Console.ReadLine();
            }
            else if ((seferyeri == "ağrı" || seferyeri == "ığdır")&&(sefergunu=="cumartesi"&& sefergunu=="pazar"))
            {
                Console.WriteLine("Haftasonu sefer bulunmamaktadır");
                Console.ReadLine();
            }
        }
    }
}

