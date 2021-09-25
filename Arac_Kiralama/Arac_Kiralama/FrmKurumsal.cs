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
    public partial class FrmKurumsal : Form
    {
        public FrmKurumsal()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        public string numara;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();

        }

        void bilgiler()
        {
            lblnumara.Text = numara;
            SqlCommand komut = new SqlCommand("Select * from TblKurumsal where acenteno=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblnumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblıd.Text = dr[0].ToString();
                lblacentead.Text = dr[1].ToString();
                lblyoneticiad.Text = dr[2].ToString();
                lbltel.Text = dr[3].ToString();
                lblsehir.Text = dr[4].ToString();
                lblnumara.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

        }
       void araclar()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblAraclar  where number=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", lblnumara.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            SqlDataAdapter de = new SqlDataAdapter("Select * from Tblilanlar", bgl.baglanti());
            DataTable dtt = new DataTable();
            de.Fill(dtt);
            dataGridView4.DataSource = dtt;
        }

        private void FrmKurumsal_Load(object sender, EventArgs e)
        {
            
            bilgiler();

            araclar();


        }

       
      
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into tblilanlar (MusteriKurum,NUmber,Model,ModelYıl,Renk,GunlukFiyat,TelefonNo,Sehir) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblacentead.Text);
            komut.Parameters.AddWithValue("@p2", lblnumara.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", txtmodelyılı.Text);
            komut.Parameters.AddWithValue("@p5", txtrenk.Text);
            komut.Parameters.AddWithValue("@p6", txtfiyat.Text);
            komut.Parameters.AddWithValue("@p7", lbltel.Text);
            komut.Parameters.AddWithValue("@p8", lblsehir.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand k1 = new SqlCommand("Insert into TblAraclar (plaka,Model,ModelYıl,Renk,Fiyat,Number) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            k1.Parameters.AddWithValue("@p1", txtplaka.Text);
            k1.Parameters.AddWithValue("@p2", txtmodel.Text);
            k1.Parameters.AddWithValue("@p3", txtmodelyılı.Text);
            k1.Parameters.AddWithValue("@p4", txtrenk.Text);
            k1.Parameters.AddWithValue("@p5", txtfiyat.Text);
            k1.Parameters.AddWithValue("@p6", lblnumara.Text);
            k1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Araç İlanınız Başarıyla Yapılmıştır");


            araclar();
        }
    }
}
