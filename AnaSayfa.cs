using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        } 

        private void button3_Click(object sender, EventArgs e)
        {
            ÜyeEkle uyeekle = new ÜyeEkle();
            uyeekle.Show();
            this.Hide();
        }

        private void UyeEkle_Click(object sender, EventArgs e)
        {
            Güncelle güncelle=new Güncelle();
            güncelle.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
