namespace proje
{
    partial class UyeListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeListele));
            this.X = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.UYEDGV = new System.Windows.Forms.DataGridView();
            this.Geri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UYEDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.X.Location = new System.Drawing.Point(884, -18);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(16, 20);
            this.X.TabIndex = 93;
            this.X.Text = "X";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(894, 51);
            this.button7.TabIndex = 92;
            this.button7.Text = "Üyeleri Listesi";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // UYEDGV
            // 
            this.UYEDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.UYEDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UYEDGV.Location = new System.Drawing.Point(12, 69);
            this.UYEDGV.Name = "UYEDGV";
            this.UYEDGV.ReadOnly = true;
            this.UYEDGV.RowTemplate.Height = 25;
            this.UYEDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UYEDGV.Size = new System.Drawing.Size(870, 372);
            this.UYEDGV.TabIndex = 91;
            // 
            // Geri
            // 
            this.Geri.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Geri.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Geri.Location = new System.Drawing.Point(527, 447);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(75, 30);
            this.Geri.TabIndex = 90;
            this.Geri.Text = "Geri Dön";
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(288, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 88;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(866, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UyeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.UYEDGV);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyeListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Listele";
            ((System.ComponentModel.ISupportInitialize)(this.UYEDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView UYEDGV;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}