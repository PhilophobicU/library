using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) // poliklinik
        {
            Poliklinik poliklinik = new Poliklinik();
            poliklinik.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) // doktor
        {
            Doktor doktor = new Doktor();
            doktor.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) // hastalar
        {
            Hastalar hastalar = new Hastalar();
            hastalar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hemsire hemsire = new Hemsire();
            hemsire.Show();
            this.Hide();
        }
    }
}
