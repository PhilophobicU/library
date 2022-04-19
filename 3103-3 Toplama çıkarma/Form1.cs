using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3103_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            button5.Visible = false;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayı1 = Convert.ToInt32(textBox1.Text);
            int sayı2 = Convert.ToInt32(textBox2.Text);
            int topla = sayı1 + sayı2;
            button5.Text = topla.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayı1 = Convert.ToInt32(textBox1.Text);
            int sayı2 = Convert.ToInt32(textBox2.Text);
            int cikar = sayı1 - sayı2;
            button5.Text = cikar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayı1 = Convert.ToInt32(textBox1.Text);
            int sayı2 = Convert.ToInt32(textBox2.Text);
            int carp = sayı1 * sayı2;
            button5.Text = carp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayı1 = Convert.ToInt32(textBox1.Text);
            int sayı2 = Convert.ToInt32(textBox2.Text);
            int bol = sayı1 / sayı2;
            button5.Text = bol.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Clear();
            button5.Text = 0.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            menuler git = new menuler();
            git.Show();
            this.Hide();
        }
    }
}
