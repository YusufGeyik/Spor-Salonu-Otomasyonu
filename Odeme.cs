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
    public partial class Odeme : Form
    {
        public Odeme(string username)
        {
            InitializeComponent();
            this.username.Text = username;

        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa(username.Text);
            anasayfa.Show();
            this.Hide();


        }

        private void X_Click(object sender, EventArgs e)
        {

            AnaSayfa anasayfa = new AnaSayfa(username.Text);
            anasayfa.Show();
            this.Hide();



        }

        private void Odeme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
