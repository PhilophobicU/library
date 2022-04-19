using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // asker classı aç // adı soyadı mesek bölüm mezuıniyet maas 
            // 2 tnae metod olacacck 
            //return bölüöüne göre günlük ücret miktarlarından maas hesapla
            //void meslek mühendis ve doktor olanlar her haftasonu geziye çıkabilsin
            //diger meslek sahipleri 2 haftabir çarşıya çıkabilsin.
            Asker asker1 = new Asker();

            Console.Write("Adınız ve Soyadınız : ");
            asker1.askerisim = Console.ReadLine();
            Console.Write("Mesleğiniz : ");
            asker1.askermeslek = Console.ReadLine();
            Console.Write("Bölümünüz : ");
            asker1.askerbolum = Console.ReadLine();
            Console.Write("Mezuniyetiniz : ");
            asker1.askermezun = Console.ReadLine();
            Console.Write("Maaşınız : ");
            asker1.askermaas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adınız : " + asker1.askerisim);
            Console.WriteLine("Mesleğiniz : " + asker1.askermeslek);
            Console.WriteLine("Bölümünüz : " + asker1.askerbolum);
            Console.WriteLine("Mezuniyetiniz : " + asker1.askermezun);
            Console.WriteLine("Askerin Aylık alacağı ücret : " + asker1.MaasHesapla(asker1.askermaas));
            asker1.Meslek(asker1.askermeslek);






        }
    }
}
