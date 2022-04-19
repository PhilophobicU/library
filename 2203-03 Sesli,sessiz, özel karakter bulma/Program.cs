using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2203_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string sesliharf = "aeıioöuü";
            string rakam = "1234567890";
            string sessiz = "qwrtypğsdfghjklşzxcvbnmç";
            int ozk;

            int seslisayac = 0;
            int rakamsayac = 0;
            int sessizsayac = 0;

            Console.Write("Bir metin giriniz : ");
            string metin = Console.ReadLine();

            foreach (char karakter in metin)
            {
                foreach (char sesli in sesliharf)
                {
                    if (sesli == karakter)
                        seslisayac++;
                }
                foreach (char rakamlar in rakam)
                {
                    if (rakamlar == karakter)
                        rakamsayac++;
                }
                foreach (char sessizler in sessiz)
                {
                    if (sessizler == karakter)
                        sessizsayac++;
                }
            }

            Console.WriteLine("metin uzunluğu : " + metin.Length);
            Console.WriteLine("metindeki sesli harf sayısı :" + seslisayac);
            Console.WriteLine("metindeki sessiz harf sayısı :" + sessizsayac);
            Console.WriteLine("metindeki rakam sayısı :" + rakamsayac);
            ozk = (metin.Length - rakamsayac - seslisayac - sessizsayac);
            Console.WriteLine("Özel karakter sayısı : " + ozk);

            Console.ReadLine();






        }
    }
}