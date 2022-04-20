using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1804_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Personel> liste = new List<Personel>()
            {
                new Personel() { Ad = "Fikret", Yasi = 23 },

             new Personel() { Ad = "Fatih", Yasi = 23 },

             new Personel() { Ad = "Merve", Yasi = 20 },

             new Personel() { Ad = "Ayşe", Yasi = 21 },

             new Personel() { Ad = "Velican", Yasi = 41 },
            };


            //dataGridView1.DataSource = liste.Where(x => x.Ad =="Fikret").ToList();

            // Adı fikret olanların listesini getirir
            // liste where (x => x.Ad == "Fikret").ToList();

            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/

            // dataGridView1.DataSource = liste.OrderBy(x => x.Yasi).ToList();
            //Yaşa göre sıralama yapar sırasıyla 20,21,22,23 olanları getirir artan sıralama

            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/

            //dataGridView2.DataSource = liste.OrderBy(x => x.Yasi).Skip(2).ToList();
            //dataGridView1.DataSource = liste.OrderBy(x => x.Yasi).ToList();

            //skip kullanımı
            //liste üzerinde istediğimiz satır sayısı kadar atlama yapar
            // örneğin skip 3 dediğimizde 0,1, ve 2. elemanları atlar ve direk 3. elemandan başkar

            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/

            //dataGridView1.DataSource = liste.Where(x => x.Ad.Contains("a")).Take(2).ToList();
            //Burada adında "a" içeren elemanları getir dedik
            // normalde "fatih" ve "ayşe" gelecekti ama take 1 dediğimiz için yalnızca "fatih"gelecek.
            // içerenleri take(x) i al

            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/


            //textBox1.Text = liste.Any(x => x.Ad == "Ayşe").ToString();
            // kayıt var olduğu için true değeri döner


            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/

            //textBox1.Text = liste.FirstOrDefault(p=>p.Yasi == 23).Ad;  // firt var olan ilk değeri getir varsa getirr yoksa sıkıntı çıkarma  firstofdefault yerine single kullanılabilir
            //textBox1.Text = liste.FirstOrDefault(p => p.Ad == "Fikret").Yasi.ToString();

            //yaşı 23 olan personelin adını getirir.

            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/

            //dataGridView1.DataSource = liste.Where(p => p.Ad.Contains("e")).ToList();
            //isminde e geçenler

            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/

            //dataGridView1.DataSource = liste.Where(x => x.Ad.StartsWith("M")).ToList();

            // Adı "M" ile başlayanları getirir.Sonuç size merve olarak gelir


            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/

            //textBox1.Text = liste.Sum(p => p.Yasi).ToString();
            // liste üerinde ki bütün yaşları toplar ve geriye 128 sonucu döner

            /*---------------------------------------------------------------------------------------*/
            ///////////////////////////////////////////////////////////////////////////////////////////
            /*---------------------------------------------------------------------------------------*/


            //textBox1.Text = liste.Where(x => x.Yasi == liste.Max(y => y.Yasi)).Select(p => p.Ad).FirstOrDefault();

            //Yaşı max olan personelin ismini getirir sonuç velican olarak geri döner

            //textBox1.Text = liste.Find(p => p.Yasi == 21).Ad.ToString();
            //Yaşı 21 olan kişinin adını geririr sonuç ayse olarak geri döner

        }
    }
}
