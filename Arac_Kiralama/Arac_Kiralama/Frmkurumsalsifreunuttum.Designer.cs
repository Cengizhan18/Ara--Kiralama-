
namespace Arac_Kiralama
{
    partial class Frmkurumsalsifreunuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmkurumsalsifreunuttum));
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtacenteno = new System.Windows.Forms.TextBox();
            this.txtyonetici = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 36);
            this.label6.TabIndex = 48;
            this.label6.Text = "Acente Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(14, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 36);
            this.label1.TabIndex = 49;
            this.label1.Text = "Kurum Yöneticisi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(115, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 36);
            this.label2.TabIndex = 50;
            this.label2.Text = "Yeni Şifre:";
            // 
            // txtacenteno
            // 
            this.txtacenteno.Location = new System.Drawing.Point(284, 62);
            this.txtacenteno.Name = "txtacenteno";
            this.txtacenteno.Size = new System.Drawing.Size(201, 41);
            this.txtacenteno.TabIndex = 51;
            // 
            // txtyonetici
            // 
            this.txtyonetici.Location = new System.Drawing.Point(284, 153);
            this.txtyonetici.Name = "txtyonetici";
            this.txtyonetici.Size = new System.Drawing.Size(201, 41);
            this.txtyonetici.TabIndex = 52;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(284, 244);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(201, 41);
            this.txtsifre.TabIndex = 53;
            this.txtsifre.UseSystemPasswordChar = true;
            this.txtsifre.TextChanged += new System.EventHandler(this.txtsifre_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.DarkViolet;
            this.button3.Location = new System.Drawing.Point(519, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 43);
            this.button3.TabIndex = 54;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkViolet;
            this.button1.Location = new System.Drawing.Point(184, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 75);
            this.button1.TabIndex = 55;
            this.button1.Text = "Şifre Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(491, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Frmkurumsalsifreunuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 427);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtyonetici);
            this.Controls.Add(this.txtacenteno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmkurumsalsifreunuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmkurumsalsifreunuttum";
            this.Load += new System.EventHandler(this.Frmkurumsalsifreunuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtacenteno;
        private System.Windows.Forms.TextBox txtyonetici;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}