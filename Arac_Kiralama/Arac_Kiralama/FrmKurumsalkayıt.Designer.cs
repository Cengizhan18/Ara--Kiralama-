
namespace Arac_Kiralama
{
    partial class FrmKurumsalkayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKurumsalkayıt));
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtyonetici = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.DarkViolet;
            this.button3.Location = new System.Drawing.Point(656, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 43);
            this.button3.TabIndex = 35;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkViolet;
            this.label8.Location = new System.Drawing.Point(57, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 36);
            this.label8.TabIndex = 34;
            this.label8.Text = "Kurumun Bulunduğu Şehir:";
            // 
            // cmbsehir
            // 
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Items.AddRange(new object[] {
            "Adana\t",
            "Adıyaman\t",
            "Afyon\t",
            "Ağrı\t",
            "Amasya\t",
            "Ankara\t",
            "Antalya\t",
            "Artvin",
            "Aydın\t",
            "Balıkesir\t",
            "Bilecik\t",
            "Bingöl",
            "Bitlis\t",
            "Bolu\t",
            "Burdur",
            "Bursa\t",
            "Çanakkale\t",
            "Çankırı\t",
            "Çorum\t",
            "Denizli\t",
            "Diyarbakır\t",
            "Edirne\t",
            "Elazığ\t",
            "Erzincan\t",
            "Erzurum\t",
            "Eskişehir\t",
            "Gaziantep\t",
            "Giresun\t",
            "Gümüşhane\t",
            "Hakkari\t",
            "Hatay\t",
            "Isparta",
            "İçel",
            "İstanbul\t",
            "İzmir\t",
            "Kars\t",
            "Kastamonu\t",
            "Kayseri\t",
            "Kırklareli\t",
            "Kırşehir\t",
            "Kocaeli",
            "Konya\t",
            "Kütahya\t",
            "Malatya\t",
            "Manisa\t",
            "Kahramanmaraş\t",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde\t",
            "Ordu\t",
            "Rize",
            "Sakarya\t",
            "Samsu",
            "Siirt\t",
            "Sinop\t",
            "Sivas\t",
            "Tekirdağ",
            "Tokat",
            "Trabzon\t",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak\t",
            "Aksaray\t",
            "Bayburt",
            "Karaman",
            "Kırıkkale\t",
            "Batman",
            "Şırnak\t",
            "Bartın",
            "Ardahan\t",
            "Iğdır\t",
            "Yalova",
            "Karabük\t",
            "Kilis\t",
            "Osmaniye\t",
            "Düzce"});
            this.cmbsehir.Location = new System.Drawing.Point(380, 298);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(209, 37);
            this.cmbsehir.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DarkViolet;
            this.button2.Location = new System.Drawing.Point(595, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 43);
            this.button2.TabIndex = 33;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkViolet;
            this.button1.Location = new System.Drawing.Point(279, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 68);
            this.button1.TabIndex = 32;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 55);
            this.label5.TabIndex = 31;
            this.label5.Text = "TUR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(106, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 55);
            this.label6.TabIndex = 30;
            this.label6.Text = "CAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MV Boli", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(189, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(425, 55);
            this.label7.TabIndex = 29;
            this.label7.Text = " ARAÇ KİRALAMA";
            // 
            // msktel
            // 
            this.msktel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktel.Location = new System.Drawing.Point(380, 226);
            this.msktel.Mask = "(599) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(209, 41);
            this.msktel.TabIndex = 3;
            this.msktel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtno
            // 
            this.txtno.Enabled = false;
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtno.Location = new System.Drawing.Point(380, 366);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(209, 41);
            this.txtno.TabIndex = 55;
            // 
            // txtyonetici
            // 
            this.txtyonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyonetici.Location = new System.Drawing.Point(380, 154);
            this.txtyonetici.Name = "txtyonetici";
            this.txtyonetici.Size = new System.Drawing.Size(209, 41);
            this.txtyonetici.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(380, 82);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(209, 41);
            this.txtad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(153, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 36);
            this.label4.TabIndex = 27;
            this.label4.Text = "Acente Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(170, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 36);
            this.label3.TabIndex = 26;
            this.label3.Text = "Acente Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(63, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Acente Yönetici Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(233, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 36);
            this.label2.TabIndex = 24;
            this.label2.Text = "Acente Ad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(380, 434);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(209, 41);
            this.txtsifre.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkViolet;
            this.label9.Location = new System.Drawing.Point(282, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 36);
            this.label9.TabIndex = 37;
            this.label9.Text = "Şifre:";
            // 
            // FrmKurumsalkayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 609);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbsehir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtyonetici);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmKurumsalkayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKurumsalkayıt";
            this.Load += new System.EventHandler(this.FrmKurumsalkayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbsehir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtyonetici;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label9;
    }
}