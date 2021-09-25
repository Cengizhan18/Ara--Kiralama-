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
    public partial class FrmMusterikayit : Form
    {
        public FrmMusterikayit()
        {
            InitializeComponent();
        }

        private void FrmMusterikayit_Load(object sender, EventArgs e)
        {
            
        }
        Sqlbaglan bgl = new Sqlbaglan();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 ;
            Random ran = new Random();
            s1 = ran.Next(100000, 1000000);

            txtno.Text = s1.ToString();

            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = txtad.Text + " " + txtsoyad.Text;

            if (txtad.TextLength < 3 || txtsoyad.TextLength < 3 || msktel.TextLength < 11 || cmbsehir.Text == " " || txtno.Text == " " || txtsifre.TextLength < 3)
            {
                MessageBox.Show("Eksik veya hatalı işlem yaptınız. Şifrenizin en az 3 karakter olmasına, numaranızın tam olmasına,  adınızın en az 3 karakter olmasına,  soyadınızın en az 3 karakter olmasına ve tüm kutucukların dolu olmasına dikkat ediniz. ");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert into TBLmusteri (adsoyad,seehir,telefon,numara,siffre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", label11.Text);
                komut.Parameters.AddWithValue("@p2", cmbsehir.Text);
                komut.Parameters.AddWithValue("@p3", msktel.Text);
                komut.Parameters.AddWithValue("@p4", txtno.Text);
                komut.Parameters.AddWithValue("@p5", txtsifre.Text);
              
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
               

                SqlCommand k1 = new SqlCommand("Insert into TblMus (MusAdSoyad,Musnumara) values (@m1,@m2)",bgl.baglanti());
                k1.Parameters.AddWithValue("@m1", label11.Text);
                k1.Parameters.AddWithValue("@m2", txtno.Text);
                k1.ExecuteNonQuery();
                bgl.baglanti().Close();


                MessageBox.Show("Kaydınız Başarılı Bir Şekilde Yapılmıştır", "Kaydınız Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtad.Clear();
                txtsoyad.Clear();
                msktel.Clear();
                txtno.Clear();
                txtsifre.Clear();
            }


        }
    }
}
