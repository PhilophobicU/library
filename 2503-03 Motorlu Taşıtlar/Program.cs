using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nesne üretme beşşel heap (referance) referans tipli

            MotorluTaşıtlar m1 = new MotorluTaşıtlar();  //katmanlı mimari projeleri entire
            m1.aracadi = "kamyon";
            m1.yakitfiyat = 22;

            Console.WriteLine("Araç Adı = " + m1.aracadi);
            Console.WriteLine("Yakıt fiyat = "+m1.yakitfiyat);
            Console.ReadLine();
        }
    }
}
// oop pbject oriented programming
// nesneye yönelimli programlama 
// class(sınıf)---> Soyut kavramlardır
//parçalara bölerek karmaşıklığı azaltır
// programların yönetimi daha kolaydır
//parçalardan bütüne giderek yapı oluştururlar


// class ---> Soyut
// nesne(obje) ---> Somut kavramlar
// oop temel ilkeler 
// abstract(soyutlama)
// kalıtım (inheriatance)
// kapsülleme, sarmalama (encapsulation)
// çok biçimlilik,çok şekillilik (poliformizm)