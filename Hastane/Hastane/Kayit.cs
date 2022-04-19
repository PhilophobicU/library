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
    public partial class Kayit : Form
    {
        bool kontrol;
        public Kayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Hospital;Integrated security= true");

        private void Kayit_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
        private void kullanicikontrol()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("select * from y_kayit where kadi=@kadi",conn);
            command.Parameters.AddWithValue("@kadi", textBox4.Text);
            SqlDataReader dr= command.ExecuteReader();
            if (dr.Read())
            {
                kontrol = false;
            }
            else
            {
                kontrol=true;
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "log_in";
            komut.Parameters.AddWithValue("kad", textBox1.Text);
            komut.Parameters.AddWithValue("sifre", textBox2.Text);

            conn.Open();
            SqlDataReader dr;
            dr = komut.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı şifre hatalı");
                textBox1.Clear();
                textBox2.Clear();
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)  //ekleme
        {
            kullanicikontrol();
            
            if (kontrol == true)
            {
                conn.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = conn;
                komut.CommandType = CommandType.StoredProcedure;
                komut.CommandText = "ykayitlol";
                komut.Parameters.AddWithValue("kad", textBox4.Text);
                komut.Parameters.AddWithValue("sifre", textBox3.Text);
                komut.Parameters.AddWithValue("mail", textBox5.Text);
                komut.Parameters.AddWithValue("tel", textBox6.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Başarıyla oluşturuldu.");
                groupBox2.Visible = false;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı başkası tarafından kullanılmış");

            }
        }
    }
}
