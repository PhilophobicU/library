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
    public partial class Aracc : Form
    {
        public Aracc()
        {
            InitializeComponent();
        }
        GaleriEntities con = new GaleriEntities();
        private void Aracc_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }
        public void Listele()
        {
            dataGridView1.DataSource = con.Araclars.ToList();
        }
        private void Arama()
        {
            
            dataGridView1.DataSource = con.Araclars.Where(x => x.Araç_Model.ToLower().Contains(textBox11.Text) || x.Araç_Model.ToUpper().Contains(textBox11.Text)).ToList();
            int aracno = Convert.ToInt32(textBox12.Text);
            var a = con.Araclars.Where(s => s.Araç_No == aracno).ToList();
            dataGridView1.DataSource = a.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araclar ekle = new Araclar();
            
            ekle.Araç_Fiyat = Convert.ToDecimal(textBox2.Text);
            ekle.Araç_Adet = Convert.ToInt32(textBox4.Text);
            ekle.Araç_Marka = textBox3.Text;
            ekle.Araç_Model = textBox11.Text;
            ekle.Araç_Yıl = Convert.ToInt32(textBox8.Text);
            ekle.Araç_Özellik = textBox7.Text;
            ekle.Araç_Motor = textBox6.Text;
            ekle.Araç_Paket = textBox5.Text;
            ekle.Araç_Renk = textBox10.Text;
            ekle.Şube_No = Convert.ToInt32(textBox9.Text);
            con.Araclars.Add(ekle);
            con.SaveChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Araclar yinele = con.Araclars.SingleOrDefault(a => a.Araç_No == id);
            yinele.Araç_Fiyat = Convert.ToDecimal(textBox2.Text);
            yinele.Araç_Adet = Convert.ToInt32(textBox4.Text);
            yinele.Araç_Marka = textBox3.Text;
            yinele.Araç_Model = textBox11.Text;
            yinele.Araç_Yıl = Convert.ToInt32(textBox8.Text);
            yinele.Araç_Özellik = textBox7.Text;
            yinele.Araç_Motor = textBox6.Text;
            yinele.Araç_Paket = textBox5.Text;
            yinele.Araç_Renk = textBox10.Text;
            yinele.Şube_No = Convert.ToInt32(textBox9.Text);
            con.SaveChanges();
            Listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["Araç_No"].Value.ToString();
            textBox2.Text = satir.Cells["Araç_Fiyat"].Value.ToString();
            textBox4.Text = satir.Cells["Araç_Adet"].Value.ToString();
            textBox3.Text = satir.Cells["Araç_Marka"].Value.ToString();
            textBox11.Text = satir.Cells["Araç_Model"].Value.ToString();
            textBox8.Text = satir.Cells["Araç_Yıl"].Value.ToString();
            textBox7.Text = satir.Cells["Araç_Özellik"].Value.ToString();
            textBox6.Text = satir.Cells["Araç_Motor"].Value.ToString();
            textBox5.Text = satir.Cells["Araç_Paket"].Value.ToString();
            textBox10.Text = satir.Cells["Araç_Renk"].Value.ToString();
            textBox9.Text = satir.Cells["Şube_No"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Araclar sil = con.Araclars.SingleOrDefault(a => a.Araç_No == id);
            con.Araclars.Remove(sil);
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

        private void button7_Click(object sender, EventArgs e)
        {
            Arama();
        }
    }
}
