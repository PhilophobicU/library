using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_05
{
    class Asker
    {
        public string askerisim;
        public string askermeslek;
        public string askerbolum;
        public string askermezun;
        public int askermaas;

        public int MaasHesapla(int askermaas)
        {
            int maas = askermaas * 30;
            return maas;
        }
        public void Meslek(string askermeslek)
        {

            if (askermeslek == "Doktor" || askermeslek == "Mühendis")
            {
                Console.WriteLine("Herhafta sonu geziye çıkabilirsiniz.");
            }
            else
            {
                Console.WriteLine("Sadece 2 haftada 1 çıkabilirsiniz.");
            }


        }
    }
}
