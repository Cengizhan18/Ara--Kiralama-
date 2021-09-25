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
    public partial class FrmMusteriGiris : Form
    {
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }

        private void FrmMusteriGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select * from TblMusteri where Numara=@p1 and siffre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    FfrmMusteri fr = new FfrmMusteri();
                    fr.no = textBox1.Text;
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Şifre veya Müşteri No Hatalı", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == " ")
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;

            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMusSifreUnuttum fr = new FrmMusSifreUnuttum();
            fr.Show();
            this.Hide();
        }
    }
}
