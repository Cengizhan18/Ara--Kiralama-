using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMusterikayit fr = new FrmMusterikayit();
            fr.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKurumsalkayıt fr = new FrmKurumsalkayıt();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKurumsalGiris fr = new FrmKurumsalGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris fr = new FrmMusteriGiris();
            fr.Show();
            this.Hide();

        }
    }
}
