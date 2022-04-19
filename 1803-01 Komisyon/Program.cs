using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1803_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir komisyoncuy sattığı mallardan fiyatı 50 tlye kadar olanlardan %3 dagha fazla olanlardan ise %2 komisyon almaktadır.klavyeden teker teker girilen 5 malın komisyonlarını
            //bulup ekrana yazdıran ve en sonunda
            //toplam komisyonunu yazdıran program
            float komisyon = 0;
            float toplamkom = 0;

            Console.Write("Malın fiyatını giriniz = ");
            for (int i = 1; i > 0; i++)
            {
                float fiyat = Convert.ToSingle(Console.ReadLine());
                if (fiyat >= 50)
                {
                    komisyon = fiyat * 0.03f;
                    Console.WriteLine(i + ". Komisyon miktarı = " + komisyon);
                    toplamkom += komisyon;

                }
                else if (fiyat < 50)
                {
                    komisyon = fiyat * 0.02f;
                    Console.WriteLine(i + ". Komisyon miktarı = " + komisyon);
                    toplamkom += komisyon;
                }
            }
            Console.WriteLine("Toplam komisyon miktarı = " + toplamkom);
        }
    }
}