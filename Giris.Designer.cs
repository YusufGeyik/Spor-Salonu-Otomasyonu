using System.Windows.Forms;

namespace proje
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
            this.textboxpw = new System.Windows.Forms.TextBox();
            this.textboxKadi = new System.Windows.Forms.TextBox();
            this.picbxuser = new System.Windows.Forms.PictureBox();
            this.picbxPw = new System.Windows.Forms.PictureBox();
            this.BtGiris = new System.Windows.Forms.Button();
            this.btSıfırla = new System.Windows.Forms.Button();
            this.picbxGiris = new System.Windows.Forms.PictureBox();
            this.X = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxpw
            // 
            this.textboxpw.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textboxpw.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxpw.ForeColor = System.Drawing.SystemColors.Info;
            this.textboxpw.Location = new System.Drawing.Point(306, 223);
            this.textboxpw.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textboxpw.Name = "textboxpw";
            this.textboxpw.PasswordChar = '*';
            this.textboxpw.Size = new System.Drawing.Size(130, 20);
            this.textboxpw.TabIndex = 1;
            this.textboxpw.Text = "Şifre";
            this.textboxpw.UseWaitCursor = true;
            // 
            // textboxKadi
            // 
            this.textboxKadi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textboxKadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxKadi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxKadi.ForeColor = System.Drawing.SystemColors.Info;
            this.textboxKadi.Location = new System.Drawing.Point(306, 179);
            this.textboxKadi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textboxKadi.Name = "textboxKadi";
            this.textboxKadi.Size = new System.Drawing.Size(130, 20);
            this.textboxKadi.TabIndex = 2;
            this.textboxKadi.Text = "Kullanıcı Adı";
            this.textboxKadi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // picbxuser
            // 
            this.picbxuser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picbxuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxuser.Image = ((System.Drawing.Image)(resources.GetObject("picbxuser.Image")));
            this.picbxuser.Location = new System.Drawing.Point(432, 179);
            this.picbxuser.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picbxuser.Name = "picbxuser";
            this.picbxuser.Size = new System.Drawing.Size(30, 20);
            this.picbxuser.TabIndex = 3;
            this.picbxuser.TabStop = false;
            this.picbxuser.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // picbxPw
            // 
            this.picbxPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxPw.Image = ((System.Drawing.Image)(resources.GetObject("picbxPw.Image")));
            this.picbxPw.Location = new System.Drawing.Point(432, 223);
            this.picbxPw.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picbxPw.Name = "picbxPw";
            this.picbxPw.Size = new System.Drawing.Size(30, 20);
            this.picbxPw.TabIndex = 4;
            this.picbxPw.TabStop = false;
            this.picbxPw.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtGiris
            // 
            this.BtGiris.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGiris.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtGiris.Location = new System.Drawing.Point(306, 251);
            this.BtGiris.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BtGiris.Name = "BtGiris";
            this.BtGiris.Size = new System.Drawing.Size(74, 32);
            this.BtGiris.TabIndex = 5;
            this.BtGiris.Text = "Giriş Yap";
            this.BtGiris.UseVisualStyleBackColor = false;
            // 
            // btSıfırla
            // 
            this.btSıfırla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSıfırla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSıfırla.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSıfırla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSıfırla.Location = new System.Drawing.Point(386, 251);
            this.btSıfırla.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btSıfırla.Name = "btSıfırla";
            this.btSıfırla.Size = new System.Drawing.Size(74, 32);
            this.btSıfırla.TabIndex = 6;
            this.btSıfırla.Text = "Sıfırla";
            this.btSıfırla.UseVisualStyleBackColor = false;
            this.btSıfırla.Click += new System.EventHandler(this.button2_Click);
            // 
            // picbxGiris
            // 
            this.picbxGiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picbxGiris.Image = ((System.Drawing.Image)(resources.GetObject("picbxGiris.Image")));
            this.picbxGiris.Location = new System.Drawing.Point(102, 13);
            this.picbxGiris.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picbxGiris.Name = "picbxGiris";
            this.picbxGiris.Size = new System.Drawing.Size(619, 472);
            this.picbxGiris.TabIndex = 0;
            this.picbxGiris.TabStop = false;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.X.Location = new System.Drawing.Point(772, 9);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(16, 20);
            this.X.TabIndex = 42;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.X);
            this.Controls.Add(this.picbxuser);
            this.Controls.Add(this.btSıfırla);
            this.Controls.Add(this.BtGiris);
            this.Controls.Add(this.picbxPw);
            this.Controls.Add(this.textboxKadi);
            this.Controls.Add(this.textboxpw);
            this.Controls.Add(this.picbxGiris);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GYM";
            ((System.ComponentModel.ISupportInitialize)(this.picbxuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textboxpw;
        private System.Windows.Forms.TextBox textboxKadi;
        private System.Windows.Forms.PictureBox picbxuser;
        private System.Windows.Forms.PictureBox picbxPw;
        private System.Windows.Forms.Button BtGiris;
        private System.Windows.Forms.Button btSıfırla;
        private System.Windows.Forms.PictureBox picbxGiris;
        private Label X;
    }
}

