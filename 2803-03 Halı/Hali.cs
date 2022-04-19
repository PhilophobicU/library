using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_03
{
    abstract class Hali // soyutlanmış bir class oldu bu classtane nesene üretemem yavru classlara kalıtım bırak öyler
        
    {
        public string marka;
        public string model;
        public int fiyat;

        public abstract void Hesapla(string marka, int fiyat)
        {

        }
        public abstract int Indirim(int fiyat);
        public void Ozellikler()
        {
            Console.WriteLine("haypır ikis ikis");
        }
    }
}
