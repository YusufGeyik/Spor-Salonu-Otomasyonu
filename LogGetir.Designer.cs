namespace proje
{
    partial class LogGetir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogGetir));
            this.username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btara = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.UYEDGV = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.Label();
            this.Geri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radiobtCafe = new System.Windows.Forms.RadioButton();
            this.radiobtUyelik = new System.Windows.Forms.RadioButton();
            this.radiobtUI = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UYEDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Enabled = false;
            this.username.Location = new System.Drawing.Point(30, 12);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // btara
            // 
            this.btara.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btara.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btara.Location = new System.Drawing.Point(168, 90);
            this.btara.Name = "btara";
            this.btara.Size = new System.Drawing.Size(75, 30);
            this.btara.TabIndex = 78;
            this.btara.Text = "Ara";
            this.btara.UseVisualStyleBackColor = false;
            this.btara.Click += new System.EventHandler(this.btara_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 77;
            this.textBox1.Text = "AD SOYAD";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(900, 51);
            this.button7.TabIndex = 76;
            this.button7.Text = "İşlem Geçmişi Sorgula";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // UYEDGV
            // 
            this.UYEDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.UYEDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UYEDGV.Location = new System.Drawing.Point(0, 125);
            this.UYEDGV.MultiSelect = false;
            this.UYEDGV.Name = "UYEDGV";
            this.UYEDGV.ReadOnly = true;
            this.UYEDGV.RowTemplate.Height = 25;
            this.UYEDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UYEDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UYEDGV.Size = new System.Drawing.Size(422, 350);
            this.UYEDGV.TabIndex = 75;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.X.Location = new System.Drawing.Point(872, 12);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(16, 20);
            this.X.TabIndex = 81;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Geri
            // 
            this.Geri.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Geri.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Geri.Location = new System.Drawing.Point(0, 508);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(75, 30);
            this.Geri.TabIndex = 83;
            this.Geri.Text = "Geri Dön";
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(674, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 30);
            this.button1.TabIndex = 82;
            this.button1.Text = "İşlem Geçmişini Getir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(418, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(451, 350);
            this.richTextBox1.TabIndex = 84;
            this.richTextBox1.Text = "";
            // 
            // radiobtCafe
            // 
            this.radiobtCafe.AutoSize = true;
            this.radiobtCafe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radiobtCafe.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtCafe.ForeColor = System.Drawing.Color.DimGray;
            this.radiobtCafe.Location = new System.Drawing.Point(211, 514);
            this.radiobtCafe.Name = "radiobtCafe";
            this.radiobtCafe.Size = new System.Drawing.Size(135, 24);
            this.radiobtCafe.TabIndex = 91;
            this.radiobtCafe.TabStop = true;
            this.radiobtCafe.Text = "GYM CAFE BAKİYE";
            this.radiobtCafe.UseVisualStyleBackColor = false;
            // 
            // radiobtUyelik
            // 
            this.radiobtUyelik.AutoSize = true;
            this.radiobtUyelik.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radiobtUyelik.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtUyelik.ForeColor = System.Drawing.Color.DimGray;
            this.radiobtUyelik.Location = new System.Drawing.Point(352, 514);
            this.radiobtUyelik.Name = "radiobtUyelik";
            this.radiobtUyelik.Size = new System.Drawing.Size(117, 24);
            this.radiobtUyelik.TabIndex = 90;
            this.radiobtUyelik.TabStop = true;
            this.radiobtUyelik.Text = "UYELIK ODEME";
            this.radiobtUyelik.UseVisualStyleBackColor = false;
            // 
            // radiobtUI
            // 
            this.radiobtUI.AutoSize = true;
            this.radiobtUI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radiobtUI.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtUI.ForeColor = System.Drawing.Color.DimGray;
            this.radiobtUI.Location = new System.Drawing.Point(476, 514);
            this.radiobtUI.Name = "radiobtUI";
            this.radiobtUI.Size = new System.Drawing.Size(111, 24);
            this.radiobtUI.TabIndex = 92;
            this.radiobtUI.TabStop = true;
            this.radiobtUI.Text = "UYELIK IŞLEM";
            this.radiobtUI.UseVisualStyleBackColor = false;
            // 
            // LogGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.ControlBox = false;
            this.Controls.Add(this.radiobtUI);
            this.Controls.Add(this.radiobtCafe);
            this.Controls.Add(this.radiobtUyelik);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btara);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.UYEDGV);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogGetir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogGetir";
            this.Load += new System.EventHandler(this.LogGetir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UYEDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btara;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView UYEDGV;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radiobtCafe;
        private System.Windows.Forms.RadioButton radiobtUyelik;
        private System.Windows.Forms.RadioButton radiobtUI;
    }
}