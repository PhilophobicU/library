using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane
{
    public partial class Sorgu : Form
    {
        public Sorgu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Hospital;Integrated security = true");


        private void metod(string sorgu)
        {
            conn.Open();
            SqlDataAdapter goruntule = new SqlDataAdapter(sorgu, conn);
            DataSet doldur = new DataSet();
            goruntule.Fill(doldur);

            dataGridView1.DataSource = doldur.Tables[0];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Select d.dokno,h.hastano,d.dokadsoyad,d.dokuzman,d.dokunvan,d.dokpolno,h.hastaadi,h.hastatc,h.hastarecete,h.hastarapor,h.hastarandevu,h.hdoktorno from Poliklinik p inner join Doktor d on p.poliklinikno = d.dokpolno join Hastalar h on d.dokno = h.hdoktorno order by p.poliklinikno asc ";
            metod(sorgu);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from Poliklinik p left join Doktor d on p.poliklinikno = d.dokpolno";
            metod(sorgu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sorgu = "select avg(hastayas) as 'Hasta Yaş Ortalaması' from Hastalar where hastaboy>160";
            metod(sorgu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "select avg(hastaboy) as 'Hasta Boy Ortalaması' from Hastalar where hastayas>30";
            metod(sorgu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sorgu = "select poliklinikuzmansayi from Poliklinik where poliklinikadi='Alerji'";
            metod(sorgu);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sorgu = "select yataksayisi from Poliklinik where poliklinikadi='Algoloji'";
            metod(sorgu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sorgu = "select dokdg,dokuzman from Doktor";
            metod(sorgu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sorgu = "select dokunvan,count(dokunvan) as 'sayısı' from Doktor group by dokunvan";
            metod(sorgu);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sorgu = "select avg(hastayas) as 'Hasta Yaş Ortalaması' from Hastalar where hastarapor='var'";
            metod(sorgu);
        }
    }
}
/* select * from Musteriler m inner join Satislar s
on m.MusteriID = s.MusteriID join Personeller p
on s.PersonelID = p.PersonelID order by NakliyeUcreti desc */