using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_01
{
    class Hayvan    // <<<<---- Base Class
    {
        public string tip;  //field alanları özellik
        public string nefesdurumu;  // private property yapıpı değerleri almayı sağlıyoruz
        public string renk;


        public void Petshop()
        {
            Console.WriteLine("sadece evcil kediler satılabilir.");
            Console.WriteLine("Yırtıcı haycanlar için özel izin gerekmektedir.");
        }
    }
}
