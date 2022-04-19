using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2803_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABSTACT CLASSLAR
            //soyutlama
            //soyut sınıflar kalıtım özelliğini kullanarak kod tekrarını azaltır
            //soyut sınıflar kendisinden türüyen sınıflardır.
            // bu sınıflardan nesne oluşturamayız
            //ancak kalıtım bıratığımız yavru classlardan nesne oluşturarak erişim sağlayabiliriz.
            //Abstract classların içinde abstract metotlar kullanabiliriz.
            //soyut sınıfı extend eden sınıf soyut sınıfın tüm soyut metotlarını override etmek zorundadır.
            //soyut sınıflar neden kullanılır ? ----> Soyut sınıfların içerisinde soyut metotların gövdesi boş olması gerekir 
            // fakat diğer metotların gövdeleri olmak zorundadır. Bunun sebebi ise kullanılacak yere göre işlem farklılığı olacağından dolayı
            // soyut sınıflar private olarak tanımlanamazlar çünkü kalıtım özelliğini her daim göstermek zorundadır.

            Hali hl = new El_Halisi();
            hl.marka = "merinos";
            hl.model = "klasik";
        }
    }
}
