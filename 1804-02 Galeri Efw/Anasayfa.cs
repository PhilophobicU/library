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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 subeler = new Form1();
            subeler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aracc araçlar = new Aracc();
            araçlar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // oluşturulmadı
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Musterii müşteri = new Musterii();
            müşteri.Show();
            this.Hide();
        }
    }
}
