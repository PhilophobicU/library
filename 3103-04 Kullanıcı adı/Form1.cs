using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3103_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //if (textBox1.Text == "admin")
            //{
            //    if (textBox2.Text == "password")
            //    {
            //        Console.WriteLine("Giriş başarılı...");
            //        fff tp = new fff();
            //        tp.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Şifre yanlış");
            //    }
            //}
            //else
            //{
            //    if (textBox2.Text == "password")
            //    {
            //        Console.WriteLine("Kullanıcı adı yanlış");
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            string sifre = textBox2.Text;

            if (isim == "admin" && sifre == "password")
            {
                MessageBox.Show("Sayın " + isim + " Hoşgeldiniz...");
                fff go = new fff();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız tekrar dene");
                textBox1.Text = "";
                textBox2.Clear();
            }
        }
    }
}
