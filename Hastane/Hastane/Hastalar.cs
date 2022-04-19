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
    public partial class Hastalar : Form
    {
        
        public Hastalar()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Hospital;Integrated security=true");

        private void Goster()
        {
            dataGridView1.Visible = true;
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "h_list";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Hastalar_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;            
            textBox3.Enabled = false;

            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;

            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "Doktorsec";
            SqlDataReader dr;

            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["dokno"]);
            }
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox3.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            maskedTextBox3.Text = dataGridView1.Rows[sec].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[sec].Cells[9].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e) // ekleme
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "h_add";
            komut.Parameters.AddWithValue("hadi", textBox1.Text);
            komut.Parameters.AddWithValue("htc", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("hdg", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("hboy", textBox2.Text);
            komut.Parameters.AddWithValue("hyas", textBox4.Text);
            komut.Parameters.AddWithValue("hrec", textBox5.Text);
            komut.Parameters.AddWithValue("hrap", textBox6.Text);
            komut.Parameters.AddWithValue("hran", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("hdokno", comboBox1.Text);
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
            komut.CommandText = "h_edit";
            komut.Parameters.AddWithValue("hno", textBox3.Text);
            komut.Parameters.AddWithValue("hadi", textBox1.Text);
            komut.Parameters.AddWithValue("htc", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("hdg", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("hboy", textBox2.Text);
            komut.Parameters.AddWithValue("hyas", textBox4.Text);
            komut.Parameters.AddWithValue("hrec", textBox5.Text);
            komut.Parameters.AddWithValue("hrap", textBox6.Text);
            komut.Parameters.AddWithValue("hran", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("hdokno", comboBox1.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button1_Click(object sender, EventArgs e) // anasayfa
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e) //delete
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "h_del";
            komut.Parameters.AddWithValue("hno", textBox9.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button2_Click(object sender, EventArgs e) // kapatma
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e) //göster
        {
            Goster();
        }

        private void button4_Click(object sender, EventArgs e)  //gizle
        {
            dataGridView1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e) // asc
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "h_vsasc";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e) //desc
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "h_vsdesc";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e) //bul
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;

            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "h_findby";

            komut.Parameters.AddWithValue("Hastano", textBox10.Text);
            komut.Parameters.AddWithValue("HastaAdSoyad", textBox8.Text);
            komut.Parameters.AddWithValue("Hastatcno", textBox11.Text);

            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable doldur = new DataTable();
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur;

            textBox8.Clear();
            textBox10.Clear();
            textBox11.Clear();
            conn.Close();
        }
    }
}
