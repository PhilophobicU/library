using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15032022_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 20 Yaş altı askere gidemez
            Console.WriteLine("Lütfen Yaşınızı Giriniz.");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas <= 20)
            {
                Console.WriteLine("Askere gitmek için uygun değilsiniz");
            }
            else
            {
                Console.WriteLine("Askere gitmek için uygunsunuz");
            }
            Console.ReadLine();
        }
    }
}