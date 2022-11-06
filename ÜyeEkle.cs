using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace proje
{
    public partial class ÜyeEkle : Form
    {

        public ÜyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        
           
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ÜyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listbxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            for (int i = 0; i < listbxBrans.Items.Count; i++)
            {
                if (listbxBrans.GetItemChecked(i) == true)
                {

                    listbxBrans.SetItemCheckState(i, 0);

                }

            }


        }

        private void picbxYeni_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Branslar = "";
            string UyelikPaketi = "";
            for (int i = 0; i < listbxBrans.Items.Count; i++)
            {
                if (listbxBrans.GetItemChecked(i) == true)
                {

                   Branslar=listbxBrans.Items[i].ToString() +" " +Branslar;

                }

            }



            if (radiobtPlat.Checked == true)
                UyelikPaketi = radiobtPlat.Text;
            else if (radiobtGold.Checked == true)
                UyelikPaketi = radiobtGold.Text;
            else if (radiobtBronze.Checked == true)
                UyelikPaketi = radiobtBronze.Text;
               
            
            if (textbxAd.Text == "" || textbxTel.Text == "" || textbxBakiye.Text == "" || textbxYas.Text == "")
            {

                MessageBox.Show("Eksik alan bırakmayınız");


            }
            else
            {

                try
                {

                    baglanti.Open();
                    string query = "insert into UyeTbl (UyeAdSoyad,UyeTelefonNo,UyeCinsiyet,UyeYas,UyeBakiye,UyeBranslar,UyePeriyot,UyelikPaketi) values ('" + textbxAd.Text + "','" + textbxTel.Text + "','" + comboxCins.SelectedItem.ToString() + "','" + textbxYas.Text + "','"+textbxBakiye.Text+"','"+Branslar+"','"+comboxPeriyot.SelectedItem+"','"+UyelikPaketi+"')";
                    SqlCommand komut= new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Kaydı Tamamlandı");
                    textbxAd.Text = "";
                    textbxBakiye.Text = "";
                    textbxTel.Text = "";
                    textbxYas.Text = "";
                    comboxCins.Text = "";
                    comboxPeriyot.Text = "";

                    radiobtBronze.Checked = false;
                    radiobtGold.Checked = false;
                    radiobtPlat.Checked = false;
                    for (int i = 0; i < listbxBrans.Items.Count; i++)
                    {
                        if (listbxBrans.GetItemChecked(i) == true)
                        {

                            listbxBrans.SetItemCheckState(i, 0);

                        }

                    }
                    baglanti.Close();

                }catch(Exception Ex)
                {

                    MessageBox.Show("Ex.Message");


                }


                

            }
        }

        private void labelPeriyot_Click(object sender, EventArgs e)
        {

        }

        private void radiobtGold_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void radiobtBronze_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Geri_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

       
    }
}
