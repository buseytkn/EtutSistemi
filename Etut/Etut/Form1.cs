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
using System.IO;

namespace Etut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KACV7HQ\\SQLEXPRESS;Initial Catalog=Etut;Integrated Security=True");
        bool durum;
        void mukerrer()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbldersler where dersad=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtDersAd.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                durum = false;
            }
            else
            { 
                durum = true;
            }
            baglanti.Close();
        }

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbldersler",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember = "DERSID";
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.DataSource = dt;
        }

        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut",baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

            for(int i=0;i<dt3.Rows.Count;i++) 
            {
                bool d = Convert.ToBoolean(dt3.Rows[i]["DURUM"]);
                if(d==true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            } 
        }
        void ogrtbrans()
        {
            SqlDataAdapter da4 = new SqlDataAdapter("select * from tbldersler",baglanti);
            DataTable dt4 = new DataTable();    
            da4.Fill(dt4);
            CmbBrans.ValueMember = "DERSID";
            CmbBrans.DisplayMember = "DERSAD";
            CmbBrans.DataSource = dt4;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
            ogrtbrans();
        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select ogrtıd,(ad+' '+soyad) as ad from tblogretmen where BRANSID=" + CmbDers.SelectedValue,baglanti);
            DataTable dt2 = new DataTable();    
            da2.Fill(dt2);
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "ad";
            CmbOgretmen.DataSource = dt2;
        }

        private void BtnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbletut (dersıd,ogretmenıd,tarıh,saat) values (@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1", CmbDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmbOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tbletut set ogrencııd=@p1,durum=@p2 where ıd=@p3",baglanti);
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3",textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblogrencı (ad,soyad,fotograf,sınıf,telefon,maıl) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", TxtSınıf.Text);
            komut.Parameters.AddWithValue("@p5", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Kaydedeildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnDersEkle_Click(object sender, EventArgs e)
        {
            mukerrer();
            if(durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbldersler (dersad) values (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtDersAd.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ders Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                derslistesi();
                ogrtbrans();
            }
            else
            {
                MessageBox.Show("Bu ders sistemde mevcut");
            }
            
        }

        private void BtnOgretmenEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblogretmen (ad,soyad,bransıd) values (@p1,@p2,@p3)",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtOgrtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtOgrtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBrans.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğretmen Bilgisi Kaydedildi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
