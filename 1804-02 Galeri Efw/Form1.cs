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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GaleriEntities con = new GaleriEntities(); // 1. adım bağlantı kurma
        public void Listele()
        {
            dataGridView1.DataSource = con.Subelers.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Subeler yinele = con.Subelers.SingleOrDefault(a =>a.Şube_No == id);
            yinele.Şube_Adı = textBox2.Text;
            yinele.Çalışan_Sayısı = Convert.ToInt32(textBox3.Text);
            yinele.Şube_Ciro = Convert.ToDecimal(textBox4.Text);
            yinele.Müşteri_No = Convert.ToInt32(textBox5.Text);
            con.SaveChanges();
            Listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subeler ekle = new Subeler(); // data ekle
            
            ekle.Şube_Adı = textBox2.Text;
            ekle.Çalışan_Sayısı = Convert.ToInt32(textBox3.Text);
            ekle.Şube_Ciro = Convert.ToDecimal(textBox4.Text);
            ekle.Müşteri_No = Convert.ToInt32(textBox5.Text);
            con.Subelers.Add(ekle);
            con.SaveChanges();
            Listele();
            //model firstte görücez
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //data göster
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["Şube_No"].Value.ToString();
            textBox2.Text = satir.Cells["Şube_Adı"].Value.ToString();
            textBox3.Text = satir.Cells["Çalışan_Sayısı"].Value.ToString();
            textBox4.Text = satir.Cells["Şube_Ciro"].Value.ToString();
            textBox5.Text = satir.Cells["Müşteri_No"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Subeler sil = con.Subelers.SingleOrDefault(a => a.Şube_No == id);
            con.Subelers.Remove(sil);
            con.SaveChanges();
            Listele();
        }
        public void Arama()
        {
            int aracno = Convert.ToInt32(textBox12.Text);
            var a = con.Subelers.Where(s => s.Şube_No == aracno).ToList();
            dataGridView1.DataSource = a.ToList();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Arama();
        }
    }
}
