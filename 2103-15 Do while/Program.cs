using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2103_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do while
            // döngü işlemini en  az bir kere yaoan ve belirtilen kolul sağlanduğu sğrece çalışan döngüdür. While döngsünde koşul döngüye girerken kullanulıyor .Do while da ise koşul en sonda kullanılır.
            // kullanıcı adı şifre durumunda do avantajlıdır.


            int sayi = 1;
            do
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            while (sayi < 1);
            Console.ReadLine();





        }
    }
}