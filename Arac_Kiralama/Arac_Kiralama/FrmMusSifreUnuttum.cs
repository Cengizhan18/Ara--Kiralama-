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
    public partial class FrmMusSifreUnuttum : Form
    {
        public FrmMusSifreUnuttum()
        {
            InitializeComponent();
        }

        Sqlbaglan bgl = new Sqlbaglan();
        private void txtsifre_TextChanged(object sender, EventArgs e)
        {
            if (txtsifre.Text == " ")
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtsifre.UseSystemPasswordChar = false;

            pictureBox2.Visible = true;
            pictureBox1.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtsifre.UseSystemPasswordChar = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblMusteri set siffre=@p1 where numara=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtsifre.Text);
            komut.Parameters.AddWithValue("@p2", txtacenteno.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifreniz başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
