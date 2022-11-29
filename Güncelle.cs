using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace proje
{
    public partial class Güncelle : Form
    {
        public Güncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void uyeGetir()
        {
            baglanti.Open();
            string query = "select *from UyeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UYEDGV.DataSource = ds.Tables[0];
            baglanti.Close();





        }
        private void picbxYeni_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }



        private void Güncelle_Load(object sender, EventArgs e)
        {
            uyeGetir();
        }
        int key = 0;


        private void X_Click_1(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            textbxAd.Text = "";
            textbxBakiye.Text = "";
            textbxTel.Text = "";
            textbxYas.Text = "";
            comboxCins.Text = "";
            comboxPeriyot.Text = "";  ///reset

            radiobtBronze.Checked = false;
            radiobtGold.Checked = false;
            radiobtPlat.Checked = false;
            for (int i = 0; i < listbxBrans1.Items.Count; i++)
            {
                if (listbxBrans1.GetItemChecked(i) == true)
                {

                    listbxBrans1.SetItemCheckState(i, 0);

                }

            }

            key = Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[0].Value.ToString());
            textbxAd.Text = UYEDGV.SelectedRows[0].Cells[1].Value.ToString();
            textbxTel.Text = UYEDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboxCins.Text = UYEDGV.SelectedRows[0].Cells[3].Value.ToString();
            textbxYas.Text = UYEDGV.SelectedRows[0].Cells[4].Value.ToString();
            textbxBakiye.Text = UYEDGV.SelectedRows[0].Cells[5].Value.ToString();
            string branslar = UYEDGV.SelectedRows[0].Cells[6].Value.ToString();
            comboxPeriyot.Text = UYEDGV.SelectedRows[0].Cells[7].Value.ToString();
            string paket = UYEDGV.SelectedRows[0].Cells[8].Value.ToString();
            if (paket == "Platinum")
                radiobtPlat.Checked = true;
            else if (paket == "Gold")
                radiobtGold.Checked = true;
            else if (paket == "Bronze")
                radiobtBronze.Checked = true;
            string[] result = branslar.Split(',');

            foreach (string str in result)
            {
                MessageBox.Show(str.ToString());
                for (int i=0; i<=8;i++)
                {
                   
                    if (listbxBrans1.Items[i].ToString() == str)
                    {

                        MessageBox.Show(listbxBrans1.Items[i].ToString());
                        listbxBrans1.SetItemChecked(i, true);
                    }
                }
                
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            textbxAd.Text = "";
            textbxBakiye.Text = "";
            textbxTel.Text = "";
            textbxYas.Text = "";
            comboxCins.Text = "";
            comboxPeriyot.Text = "";

            radiobtBronze.Checked = false;
            radiobtGold.Checked = false;
            radiobtPlat.Checked = false;
            for (int i = 0; i < listbxBrans1.Items.Count; i++)
            {
                if (listbxBrans1.GetItemChecked(i) == true)
                {

                    listbxBrans1.SetItemCheckState(i, 0);

                }

            }


        }

        private void btSil_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek üyeyi seçiniz");



            }

            else
            {
                try
                {

                    baglanti.Open();
                    string query = "delete from UyeTbl where UyeId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Silindi");
                    baglanti.Close();
                    key = 0;

                }catch(Exception Error)
                {
                    
                    MessageBox.Show(Error.Message);

                }



            }
            uyeGetir();
        
        }

        private void btGunc_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek üyeyi seçiniz");



            }

            else
            {
                try
                {

                    baglanti.Open();
                    string query = "delete from UyeTbl where UyeId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Silindi");
                    baglanti.Close();

                }
                catch (Exception Error)
                {

                    MessageBox.Show(Error.Message);

                }



            }
        }
    }
}
//String MyStr = ListBox.items[5].ToString();