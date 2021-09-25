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
namespace Arac_Kiralama
{
    public partial class FfrmMusteri : Form
    {
        public FfrmMusteri()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();

        public string no;
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }
        void bilgiler()
        {
            lblno.Text = no;

            SqlCommand komut = new SqlCommand("Select * from TblMusteri where numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1].ToString();
                lblsehir.Text = dr[2].ToString();
                lbltelefon.Text = dr[3].ToString();
                lblıd.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();


        }
        void arac()
        {
            SqlDataAdapter da= new SqlDataAdapter("Execute arac ",bgl.baglanti());
             DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

           

        }

        private void FfrmMusteri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'araçKiralamaDataSet3.Tblİlanlar' table. You can move, or remove it, as needed.
            this.tblİlanlarTableAdapter2.Fill(this.araçKiralamaDataSet3.Tblİlanlar);

            bilgiler();
            arac();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtfiyat.Text==" " || txtmodel.Text==" " || txtmodelyil.Text==" " || txtrenk.Text==" ")
            {
                MessageBox.Show("Lütfen Tüm Kutucukları Doğru ve Eksiksiz Bir Şekilde Doldurduğunuzdan Emin Olunuz.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert into Tblilanlar (MusteriKurum,Number,Model,ModelYıl,Renk,GunlukFiyat,TelefonNo,Sehir,ıd2) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9) ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lbladsoyad.Text);
                komut.Parameters.AddWithValue("@p2", lblno.Text);
                komut.Parameters.AddWithValue("@p3", txtmodel.Text);
                komut.Parameters.AddWithValue("@p4", txtmodelyil.Text);
                komut.Parameters.AddWithValue("@p5", txtrenk.Text);
                komut.Parameters.AddWithValue("@p6", txtfiyat.Text);
                komut.Parameters.AddWithValue("@p7", lbltelefon.Text);
                komut.Parameters.AddWithValue("@p8", lblsehir.Text);
                komut.Parameters.AddWithValue("@p9", lblıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kiralık Araç İlanınız Verilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tblİlanlarTableAdapter2.Fill(this.araçKiralamaDataSet3.Tblİlanlar);
            }

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox6.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            label2.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Insert into TblHareket (Gönderen,Alan,Mesaj,GNo,ano,gıd) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblıd.Text);
                komut.Parameters.AddWithValue("@p2", label2.Text);
                komut.Parameters.AddWithValue("@p3", richTextBox1.Text);
                komut.Parameters.AddWithValue("@p4", lblıd.Text);
                komut.Parameters.AddWithValue("@p5", label2.Text);
                komut.Parameters.AddWithValue("@p6", lblıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                arac();
            }
            catch (Exception)
            {

                MessageBox.Show("Yalnızca Kişilere Mesaj Gönderebilirsiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox6.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            label2.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }
    }
}
