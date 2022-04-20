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
    public partial class Kayitt : Form
    {
        public Kayitt()
        {
            InitializeComponent();
        }
        GaleriEntities con = new GaleriEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayit ekle = new Kayit();
            ekle.Kullanıcı_Adı = textBox3.Text;
            ekle.Şifre = textBox4.Text;
            ekle.Mail = textBox5.Text;
            ekle.Telefon = textBox6.Text;
            ekle.Tc = textBox7.Text;
            ekle.Şirket_Kodu = Convert.ToInt32(textBox8.Text);
            con.Kayits.Add(ekle);
            con.SaveChanges();
        }

        private void Kayitt_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            
        }
    }
}
