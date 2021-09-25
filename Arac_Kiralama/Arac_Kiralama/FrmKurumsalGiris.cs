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
    public partial class FrmKurumsalGiris : Form
    {
        public FrmKurumsalGiris()
        {
            InitializeComponent();
        }
        Sqlbaglan bgl = new Sqlbaglan();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frmkurumsalsifreunuttum fr = new Frmkurumsalsifreunuttum();
            fr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select * from TblKurumsal where acenteno=@p1 and sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    FrmKurumsal fr = new FrmKurumsal();
                    fr.numara = textBox1.Text;
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;

            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }
    }
}
