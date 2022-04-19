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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Hospital;Integrated security = true");

        private void Goster()
        {
            dataGridView1.Visible = true;
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "doc_list";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
            maskedTextBox3.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sec].Cells[8].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e) // göster
        {
            Goster();
        }

        private void button4_Click(object sender, EventArgs e) // gizle
        {
            dataGridView1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e) // ekleme
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "doc_add";
            komut.Parameters.AddWithValue("dokad",textBox2.Text);
            komut.Parameters.AddWithValue("doktc", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("dokuzm", textBox4.Text);
            komut.Parameters.AddWithValue("dokunv", textBox5.Text);
            komut.Parameters.AddWithValue("doktel", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("dokadres", textBox6.Text);
            komut.Parameters.AddWithValue("dokdg", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("dokpolno", textBox3.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }


        private void button10_Click(object sender, EventArgs e) // güncelle
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "doc_edit";
            komut.Parameters.AddWithValue("dokno", textBox1.Text);
            komut.Parameters.AddWithValue("dokad", textBox2.Text);
            komut.Parameters.AddWithValue("doktc", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("dokuzm", textBox4.Text);
            komut.Parameters.AddWithValue("dokunv", textBox5.Text);
            komut.Parameters.AddWithValue("doktel", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("dokadres", textBox6.Text);
            komut.Parameters.AddWithValue("dokdg", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("dokpolno", textBox3.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button5_Click(object sender, EventArgs e) // a to z
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "doc_vsasc";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e) // z to a
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "doc_vsdesc";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e) // delete
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "doc_del";
            komut.Parameters.AddWithValue("dokno", textBox10.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button11_Click(object sender, EventArgs e) // clear
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
        }
    }
}
