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

// sorun 1 update metodu yanyana yazılmıyor
//

namespace Pastane
{
    public partial class Satici : Form
    {
        public Satici()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.;Database=Pastane;Integrated security=true");


        private void Satici_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand komut = new SqlCommand("Select * from Satıcı",conn);

            SqlDataReader dr;
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SaticiNo"]);
            }
        }
        private void Listele(string baglan)
        {
            SqlDataAdapter dr = new SqlDataAdapter(baglan, conn);   
            DataSet doldur = new DataSet(); 
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0]; 
        }

        private void button1_Click(object sender, EventArgs e)  //listele
        {
            Listele("select * from Satıcı");
        }

        private void button2_Click(object sender, EventArgs e)  //ekle
        {
            conn.Open();

            SqlCommand komut = new SqlCommand("insert into Satıcı (SaticiAdSoyad,SaticiAdres,Saticiİl,Saticiİlce)" +
                "values (@saticiadsoyad,@saticiadres,@saticiil,@saticiilce)",conn);

           
            komut.Parameters.AddWithValue("saticiadsoyad", textBox2.Text);
            komut.Parameters.AddWithValue("saticiadres", textBox3.Text);
            komut.Parameters.AddWithValue("saticiil", textBox4.Text);
            komut.Parameters.AddWithValue("saticiilce", textBox5.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            Listele("select * from Satıcı");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand komut = new SqlCommand("update Satıcı set SaticiAdSoyad='" + textBox2.Text.ToString() + "'where SaticiNo='" + textBox1.Text.ToString()+ "' ", conn) ;
            komut.ExecuteNonQuery();
            Listele("select * from Satıcı");
            conn.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("delete from Satıcı where SaticiNo='" + textBox1.Text.ToString() + "' ", conn);
            komut.ExecuteNonQuery();
            Listele("Select * from Satıcı");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from Satıcı where SaticiNo like '%" + textBox1.Text + "%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
           
            conn.Close();
        }
    }
}
