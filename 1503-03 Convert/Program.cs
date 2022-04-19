using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //tür&veri dönüşümü  parse,convert
            //neden yaparaız c# her şey string olarak değer alır bu değerleri istediğimiz tipe dönüştürmek için tür dönüşümü yaparz örn : int ,char

            Console.WriteLine("İsminizi giriniz");
            string isim = Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz :");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("İsminiz : " + isim);
            Console.WriteLine("Yaşınız :" + yas);
            Console.ReadLine();

            //doğum tarihi gir
            // şimdiki yılı gir yaşı bul

            Console.WriteLine("Doğum yılınızı giriniz :");
            int dyili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tarihi giriniz :");
            int yıl = Convert.ToInt32(Console.ReadLine());
            int yass = yıl - dyili;
            Console.WriteLine("Yasiniz : " + yass);
            Console.ReadLine();
        }
    }
}