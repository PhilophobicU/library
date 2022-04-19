using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_04
{
    class Flower
    {

        public string cicekadi;
        public string renk;
        public string kokudurumu;
        public int fiyat;
        public int adet;

        public int FiyatHesapla(int adet,int fiyat)
        {
            int fatura = adet * fiyat;
            return fatura;

        }
        public void Ozellik(string cad,string renk)
        {
            if (cad == "gül" || cad == "kaktüs")
            {
                Console.WriteLine("Kırmızı ve Sarı renklerimiz mevcuttur bir demet alan bir demet bedava gelinnn");
            }
            else
            {
                Console.WriteLine("diğer çiçeklerde %2 indirim var.");
            }

        }






    }
}
