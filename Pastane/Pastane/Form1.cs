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


namespace Pastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;Database=Pastane;Integrated security = true");
        // SqlConnection baglanti = new SqlConnection(@"Dta Soruce=DESKTOP-MO5HLC4\\SA;Initial Catalog=Pastane;Integrated Security=True");

        public void Listele(string baglan)
        {

            SqlDataAdapter dr = new SqlDataAdapter(baglan, baglanti);
            DataSet doldur = new DataSet();  //dataetler datatablelardan daha büyüktür
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0]; // tek tablo olduğu için indis 0
        }


        private void button6_Click(object sender, EventArgs e)  //rapor
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Listele("Select * from Urunler");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Urunler(UrunAdi,UrunFiyat,KullanimTarihi,UretimTarihi,SaticiNo)" +
                " values(@UrunAdi,@UrunFiyat,@KullanimTarihi,@UretimTarihi,@SaticiNo)", baglanti);

            komut.Parameters.AddWithValue("@UrunAdi", textBox2.Text);
            komut.Parameters.AddWithValue("@UrunFiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@KullanimTarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@UretimTarihi", dateTimePicker2.Text);
            komut.Parameters.AddWithValue("@SaticiNo", comboBox1.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();
            Listele("Select * from Urunler");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Urunler set UrunFiyat='" + textBox3.Text.ToString() + "'where UrunNo='" + textBox1.Text.ToString() + "' ", baglanti);
            komut.ExecuteNonQuery();
            Listele("Select * From Urunler");
            baglanti.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete from Urunler where UrunNo=@UrunNo", baglanti);
            komut.Parameters.AddWithValue("@UrunNo", textBox1.Text);

            komut.ExecuteNonQuery();
            Listele("Select * from Urunler");
            baglanti.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Urunler  where UrunNo like '%" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * from Satıcı", baglanti);

            SqlDataReader dr;
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SaticiNo"]);
            }

            baglanti.Close();
        }
    }
}
