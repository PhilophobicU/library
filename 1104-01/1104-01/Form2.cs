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


namespace _1104_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // SqlConnection con = new SqlConnection("Server=.;Database=Okul;uid=sa;pwd=1234"); // sql bağlantısı yapacağımız için bu classı kullancağmızı belirtiyoruz. //sql auth.
        SqlConnection con1 = new SqlConnection("Server=.;Database=Okul;Integrated Security=true");  //windows auth.  //1. Adım
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void Goster()
        {
            SqlCommand komut = new SqlCommand();                //2. adım
            komut.Connection = con1;                            //veri tabanına bağlan
            komut.CommandType = CommandType.StoredProcedure;    // komut tipi prosedur tipi kullan
            komut.CommandText = "OG";                           // komut ismi OG    c#a tanıma kısmı
            SqlDataAdapter dp = new SqlDataAdapter(komut);      //Aracı sql dataadapter düzensiz bir şekilde
            DataTable dt = new DataTable();                     // datatable yada dataset verileri düzenler
            dp.Fill(dt);                                        // Verileri doldur
            dataGridView1.DataSource = dt;
            //buton4tekileri içindekileri buraya al buton4ün içerisine sadece Goster(); yaz
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Goster();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand komut = new SqlCommand();                
            komut.Connection = con1;                            
            komut.CommandType = CommandType.StoredProcedure;    
            komut.CommandText = "OAdd";
            komut.Parameters.AddWithValue("AdSoyad", textBox2.Text);
            komut.Parameters.AddWithValue("TcNo", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("Telefon", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("Mail", textBox5.Text);
            komut.Parameters.AddWithValue("Adres", textBox6.Text);
            komut.Parameters.AddWithValue("Dersno", textBox7.Text);
            komut.ExecuteNonQuery();
            con1.Close();
            Goster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OY";
            komut.Parameters.AddWithValue("OgrenciNo",textBox1.Text);
            komut.Parameters.AddWithValue("AdSoyad", textBox2.Text);
            komut.Parameters.AddWithValue("TcNo", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("Telefon", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("Mail", textBox5.Text);
            komut.Parameters.AddWithValue("Adres", textBox6.Text);
            komut.Parameters.AddWithValue("Dersno", textBox7.Text);
            komut.ExecuteNonQuery();
            con1.Close();
            Goster();
        }
        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // data cellclick hücreye tıklanınca properties şimşek
            int sectim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sectim].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sectim].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[sectim].Cells[6].Value.ToString();

            // datanın üstüne bastığımızda bilgileri tekrar doldurur ve yenileye bastığımızda tekrar getirir
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OSL";
            komut.Parameters.AddWithValue("OgrenciNo", textBox1.Text);
            komut.ExecuteNonQuery();
            con1.Close();
            Goster();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
/* 
 * Veri tabanı bağlantısı crud
 * 2 adet yöntem vardır
 * 1. adonet --> dapper hız         daha hızlı sonuç döndürür fakat kod fazlalığından dolayı yazılımcıyı yorar
 * 2. entity framework              hız bakımından ado.netten daha yavas sonuc döndürebilir fakat yazıkımcı için 
 * ve yeni programlarla entregrasyonu açısından daha avantajlıdır.
 * 
 * adonetin içinde kullandığımız sqlconnection veri tabanımızın bağlantısı yapan classtır.
 *                               sql command     crud sql komutlarını yazıyoruz.
 *                               sqldataadapter  datagridviewe aracı / verileri düzensiz bir şekilde alır
 *                               datatable,dataset  verileri düzenli bir şekle sokr ve datagridviewda gözükmesini sağlar
 *                               sqldatareader   verileri okur ilgili verileri tool alanlarına getirir.
 *                               
 *                               işlemleri yaparken executenonquerry() işlemlerimizin kayıt edildiğini ver satır sayısını kontrol eder.
 *                               
 *                               baglanti.open() ----> veri tabanını aç bağlan işlem yap
 *                               (cud) işlemlerinde create update delete
 *                               baglanti.close() ---> veri tabanındaki işlem bitince kapatır.
kullanılan bu classların bulunduğu yer sqldataClient(); dll kütüpane demektir.
 
 
 
 
 */
 