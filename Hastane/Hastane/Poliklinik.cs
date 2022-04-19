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
    public partial class Poliklinik : Form
    {
        public Poliklinik()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Hospital;Integrated security = true");
        
        private void Goster()
        {
            dataGridView1.Visible = true;
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "pol_list";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            textBox3.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
        }

        private void Poliklinik_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
        }

        private void button3_Click(object sender, EventArgs e) //göster
        {
            Goster();
        }

        private void button9_Click(object sender, EventArgs e) // ekleme
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "pol_add";
            komut.Parameters.AddWithValue("poladi", textBox2.Text);
            komut.Parameters.AddWithValue("poluzms",textBox1.Text);
            komut.Parameters.AddWithValue("polbask", textBox4.Text);
            komut.Parameters.AddWithValue("polbash",textBox5.Text);
            komut.Parameters.AddWithValue("yatak",textBox6.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button10_Click(object sender, EventArgs e)//edit
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection=conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "pol_edit";
            komut.Parameters.AddWithValue("polno", textBox3.Text);
            komut.Parameters.AddWithValue("poladi",textBox2.Text);
            komut.Parameters.AddWithValue("poluzms", textBox1.Text);
            komut.Parameters.AddWithValue("polbask",textBox4.Text);
            komut.Parameters.AddWithValue("polbash", textBox5.Text);
            komut.Parameters.AddWithValue("yatak",textBox6.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button5_Click(object sender, EventArgs e) // a to z
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "pol_vsasc";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e) //z to a
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandText = "pol_vsdesc";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e) //delete
        {
            conn.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection=conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "pol_del";          
            komut.Parameters.AddWithValue("polno", textBox9.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Goster();
        }

        private void button1_Click(object sender, EventArgs e) //anasayfa
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) // gizle
        {
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e) // kapatma
        {
            Environment.Exit(0);
        }
    }
}
