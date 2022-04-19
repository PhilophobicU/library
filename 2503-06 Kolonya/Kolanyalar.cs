using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_06
{
    class Kolanyalar
    {
        private string markaadi;
        private int fiyat;
        private int uretimyili;
        private string mensei;

        // encapsulation kapsülleme,sarmalama 
        // private field propertlyeer açıyoruz kullanıcıya
        // 2 anahtar var 1. get 2. set kelimeleri
        // Get veriyi okur kullanıcıya döndürür
        // set ise veri atama diyebiliriz
        //uretimyili = 2010 setle değer ataması yaparken 
        //    2010 --- get   ile değer okurum  ----> Return
            public string Markaadi
        {
            get { return markaadi; }
            set { markaadi = value; }
        }
        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                if (value>20 && value <50)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Pahalı");
                    fiyat = value;
                }
            }
        }
        public int Uretim
        {
            get { return uretimyili; }
            set
            {
                if (value > 2010 && value < 2022)
                {
                    uretimyili = value;
                }
                else
                {
                    Console.WriteLine("Bu yıllar olmaz");
                }
            }
        }
    }
}
