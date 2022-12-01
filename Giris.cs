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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void BtGiris_Click(object sender, EventArgs e)
        {
            if (textboxKadi.Text == "admin" && textboxpw.Text == "admin")
            {
                string kullaniciadi = "admin";
                AnaSayfa anasayfa = new AnaSayfa(kullaniciadi);
                anasayfa.Show();
                this.Hide();    



                /* string kullaniciAdi = "admin";
                AnaSayfa = kullaniciAdi;
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
                */


            }
            else
                MessageBox.Show("Yanlış kullanıcı adı/şifre");
        }

        private void btSıfırla_Click(object sender, EventArgs e)
        {
            textboxKadi.Text = "";
            textboxpw.Text = "";
        }
    }
}
