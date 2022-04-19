using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_01
{
    class Program
    {
        static void Main(string[] args)
        {





            Kedigiller kedi1 = new Kedigiller();
            kedi1.nefesdurumu = "akciğer";
            kedi1.renk = "beyaz";
            kedi1.tip = "süs kedisi";
            kedi1.kilo = 16;
            kedi1.cins = "kaplan";
            kedi1.uremezamani = "mart";
            kedi1.kmsaat = 2;
            kedi1.kosmahizi = 100;
            kedi1.Petshop();
            kedi1.Yonlendir(kedi1.kilo,kedi1.cins);
            Console.ReadLine();
        }
    }
}
// oop temel ilkeler
//1) kapsülleme 
//2) kalıtım     miras bırakma birden fazla classtan dolaylı bir şekilde kalıtım alınabilir
//3) soyutlama
//4) poliformizm
//construcator,sealed
// kalıtım kendi içerisinde 3e ayrılır 1. single level kalıtım bir classtan başka bir classa aktarma sağlar.
// ana classa base,super,temel gibi çeşitli isimler vardır.
// diğerine yavru,alt veya sub class gibi isimler vardır.
//multi level kalıtım  base classtan başka bir classa kalıtım olayıdır kesişim paydası gibi
// hiyerarşik kalıtım base classın birden fazla subclassı oluyor onlara kalıtım bırakıyor.