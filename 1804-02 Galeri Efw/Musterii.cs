using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1804_04
{
    public partial class Musterii : Form
    {
        public Musterii()
        {
            InitializeComponent();
        }
        GaleriEntities con = new GaleriEntities();

        private void Musterii_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
        private void Listele()
        {
            dataGridView1.DataSource = con.Musteris.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri ekle = new Musteri();
            ekle.Şirket_No = Convert.ToInt32(textBox1.Text);
            ekle.Şirket_Adı = textBox2.Text;
            ekle.Şirket_Sektör = textBox3.Text;
            ekle.Şirket_Ceo = textBox4.Text;
            ekle.Şirket_Araç_Sayısı = Convert.ToInt32(textBox5.Text);
            ekle.Şirket_Kodu = Convert.ToInt32(textBox6.Text);
            con.Musteris.Add(ekle);
            con.SaveChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri yinele = new Musteri();
            yinele.Şirket_No = Convert.ToInt32(textBox1.Text);
            yinele.Şirket_Adı = textBox2.Text;
            yinele.Şirket_Sektör = textBox3.Text;
            yinele.Şirket_Ceo = textBox4.Text;
            yinele.Şirket_Araç_Sayısı = Convert.ToInt32(textBox5.Text);
            yinele.Şirket_Kodu = Convert.ToInt32(textBox6.Text);
            con.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["Şirket_No"].Value.ToString();
            textBox2.Text = satir.Cells["Şirket_Adı"].Value.ToString();
            textBox3.Text = satir.Cells["Şirket_Sektör"].Value.ToString();
            textBox4.Text = satir.Cells["Şirket_Ceo"].Value.ToString();
            textBox5.Text = satir.Cells["Şirket_Araç_Sayısı"].Value.ToString();
            textBox6.Text = satir.Cells["Şirket_Kodu"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Musteri sil = con.Musteris.SingleOrDefault(a => a.Şirket_No == id);
            con.Musteris.Remove(sil);
            con.SaveChanges();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Arama()
        {
            int şirketno = Convert.ToInt32(textBox12.Text);
            var a = con.Musteris.Where(s => s.Şirket_No == şirketno).ToList();
            dataGridView1.DataSource = a.ToList();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Arama();
        }
    }
}
