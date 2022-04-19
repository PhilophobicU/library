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
    public partial class Hemsire : Form
    {
        public Hemsire()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Hospital;Integrated security=true");

        private void Goster()
        {
            dataGridView1.Visible = true;
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "hem_list";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void Hemsire_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) // geri
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)  //ekle
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection=conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "hem_add";
            komut.Parameters.AddWithValue("head",textBox1.Text);
            komut.Parameters.AddWithValue("hetc", textBox2.Text);
            komut.Parameters.AddWithValue("hemy", textBox3.Text);
            komut.Parameters.AddWithValue("hemm", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("hemn", textBox5.Text);
            komut.Parameters.AddWithValue("hemt", textBox6.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button10_Click(object sender, EventArgs e) // düzenle
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "hem_edit";
            komut.Parameters.AddWithValue("hemo", textBox10.Text);
            komut.Parameters.AddWithValue("head", textBox1.Text);
            komut.Parameters.AddWithValue("hetc", textBox2.Text);
            komut.Parameters.AddWithValue("hemy", textBox3.Text);
            komut.Parameters.AddWithValue("hemm", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("hemn", textBox5.Text);
            komut.Parameters.AddWithValue("hemt", textBox6.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button2_Click(object sender, EventArgs e) //kapat
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)//göster
        {
            Goster();
        }

        private void button4_Click(object sender, EventArgs e) //gizle
        {
            dataGridView1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e) // a to z
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "hem_vsasc";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource=dt;
        }

        private void button6_Click(object sender, EventArgs e)  // z to a
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "hem_vsdesc";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox10.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();

        }

        private void button8_Click(object sender, EventArgs e) // sil
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "hem_del";
            komut.Parameters.AddWithValue("hemo", textBox9.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }
    }
}
