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
    public partial class FrmKurumsalkayıt : Form
    {
        public FrmKurumsalkayıt()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();
        private void button2_Click(object sender, EventArgs e)
        {
            int s1;
            Random ran = new Random();
            s1 = ran.Next(100000, 1000000);

            txtno.Text = s1.ToString();

            button2.Enabled = false;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtad.TextLength < 3 || txtyonetici.TextLength < 5 || msktel.TextLength < 11 || cmbsehir.Text == " " || txtno.Text == " " || txtsifre.TextLength < 3)
            {
                MessageBox.Show("Eksik veya hatalı işlem yaptınız. Şİfrenizin en az 3 karakter olmasına, numaranızın tam olmasına, kurum adının en az 3 karakter olmasına, yönetici ad soyadının en az 5 karakter olmasına ve tüm kutucukların dolu olmasına dikkat ediniz. ");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert into TblKurumsal (acentead,yoneticiadsoyad,acentetel,sehir,acenteno,sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtyonetici.Text);
                komut.Parameters.AddWithValue("@p3", msktel.Text);
                komut.Parameters.AddWithValue("@p4", cmbsehir.Text);
                komut.Parameters.AddWithValue("@p5", txtno.Text);
                komut.Parameters.AddWithValue("@p6", txtsifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Başarılı Bir Şekilde Yapılmıştır", "Kaydınız Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtad.Clear();
                txtyonetici.Clear();
                msktel.Clear();
                txtno.Clear();
                txtsifre.Clear();

            }





        }

        private void FrmKurumsalkayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
