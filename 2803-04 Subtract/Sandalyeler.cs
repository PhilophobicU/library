using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_04
{
    abstract class Sandalyeler
    {
        public int urunno;
        public string marka;
        public string model;
        public int kdv;
        public int fiyat;

        public abstract int ZamYap(string model, int fiyat);
        public abstract void KdvHesapla(int fiyat);

        public void HediyeKampanya(string marka, string model)
        {
            if (marka == "bellona" && marka == "klasik")
            {
                Console.WriteLine("Ütü kazandınız.");
            }
            else
            {
                Console.WriteLine("paspas kazandınız.");
            }
        }
        public void Verial()
        {
            Console.WriteLine("sandalye No giriniz.");
            urunno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marka giriniz");
            marka = Console.ReadLine();
            Console.WriteLine("Model giriniz");
            model = Console.ReadLine();
            Console.WriteLine("Kdv giriniz");
            kdv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiyat giriniz");
            fiyat = Convert.ToInt32(Console.ReadLine());
        }
        public void Bas()
        {
            Console.WriteLine("Sandalye no : "+urunno);
            Console.WriteLine("marka : "+marka);
            Console.WriteLine("model : "+model);
            Console.WriteLine("kdv " + kdv);
            Console.WriteLine("fiyat : "+fiyat);
            Console.ReadLine();
        }
        
    }
}
