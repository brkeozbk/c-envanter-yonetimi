namespace siparisTakip
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kayitButton = new System.Windows.Forms.Button();
            this.k_adiBox = new System.Windows.Forms.TextBox();
            this.sifreBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.u_adiBox = new System.Windows.Forms.TextBox();
            this.u_soyadiBox = new System.Windows.Forms.TextBox();
            this.girisButton = new System.Windows.Forms.Button();
            this.k_adiBoxGiris = new System.Windows.Forms.TextBox();
            this.sifreBoxGiris = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayitButton
            // 
            this.kayitButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.kayitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitButton.Location = new System.Drawing.Point(109, 230);
            this.kayitButton.Name = "kayitButton";
            this.kayitButton.Size = new System.Drawing.Size(258, 65);
            this.kayitButton.TabIndex = 0;
            this.kayitButton.Text = "KAYIT OL";
            this.kayitButton.UseVisualStyleBackColor = false;
            this.kayitButton.Click += new System.EventHandler(this.kayitButton_Click_1);
            // 
            // k_adiBox
            // 
            this.k_adiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.k_adiBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.k_adiBox.Location = new System.Drawing.Point(109, 124);
            this.k_adiBox.Name = "k_adiBox";
            this.k_adiBox.Size = new System.Drawing.Size(258, 31);
            this.k_adiBox.TabIndex = 1;
            // 
            // sifreBox
            // 
            this.sifreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sifreBox.Location = new System.Drawing.Point(109, 173);
            this.sifreBox.Name = "sifreBox";
            this.sifreBox.Size = new System.Drawing.Size(258, 31);
            this.sifreBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // u_adiBox
            // 
            this.u_adiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.u_adiBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.u_adiBox.Location = new System.Drawing.Point(109, 31);
            this.u_adiBox.Name = "u_adiBox";
            this.u_adiBox.Size = new System.Drawing.Size(258, 31);
            this.u_adiBox.TabIndex = 5;
            // 
            // u_soyadiBox
            // 
            this.u_soyadiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.u_soyadiBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.u_soyadiBox.Location = new System.Drawing.Point(109, 78);
            this.u_soyadiBox.Name = "u_soyadiBox";
            this.u_soyadiBox.Size = new System.Drawing.Size(258, 31);
            this.u_soyadiBox.TabIndex = 6;
            // 
            // girisButton
            // 
            this.girisButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.girisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisButton.Location = new System.Drawing.Point(69, 230);
            this.girisButton.Margin = new System.Windows.Forms.Padding(2);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(258, 63);
            this.girisButton.TabIndex = 8;
            this.girisButton.Text = "Giriş Yap";
            this.girisButton.UseVisualStyleBackColor = false;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click_1);
            // 
            // k_adiBoxGiris
            // 
            this.k_adiBoxGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.k_adiBoxGiris.ForeColor = System.Drawing.SystemColors.MenuText;
            this.k_adiBoxGiris.Location = new System.Drawing.Point(97, 65);
            this.k_adiBoxGiris.Name = "k_adiBoxGiris";
            this.k_adiBoxGiris.Size = new System.Drawing.Size(258, 29);
            this.k_adiBoxGiris.TabIndex = 9;
            // 
            // sifreBoxGiris
            // 
            this.sifreBoxGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreBoxGiris.ForeColor = System.Drawing.SystemColors.MenuText;
            this.sifreBoxGiris.Location = new System.Drawing.Point(97, 123);
            this.sifreBoxGiris.Name = "sifreBoxGiris";
            this.sifreBoxGiris.Size = new System.Drawing.Size(258, 29);
            this.sifreBoxGiris.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.k_adiBoxGiris);
            this.groupBox1.Controls.Add(this.sifreBoxGiris);
            this.groupBox1.Controls.Add(this.girisButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(27, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 316);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Yap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.kayitButton);
            this.groupBox2.Controls.Add(this.k_adiBox);
            this.groupBox2.Controls.Add(this.sifreBox);
            this.groupBox2.Controls.Add(this.u_soyadiBox);
            this.groupBox2.Controls.Add(this.u_adiBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(412, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 316);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kayıt Oluştur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soy Adınız:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adınız:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(827, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kayitButton;
        private System.Windows.Forms.TextBox k_adiBox;
        private System.Windows.Forms.TextBox sifreBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox u_adiBox;
        private System.Windows.Forms.TextBox u_soyadiBox;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.TextBox k_adiBoxGiris;
        private System.Windows.Forms.TextBox sifreBoxGiris;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

