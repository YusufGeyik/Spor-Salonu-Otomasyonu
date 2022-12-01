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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje
{
    
    public partial class ÜyeEkle : Form
    {
       
       
        public ÜyeEkle(string username)
        {
            InitializeComponent();
            this.username.Text = username;

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
            textbxCafe.Text = "";
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

        

        private void button1_Click(object sender, EventArgs e)
        {
         
            int Bakiye;
            int tutar;
            int uyelikfiyat = 0;
            string Branslar = "";
            string UyelikPaketi = "";
            for (int i = 0; i < listbxBrans.Items.Count; i++)
            {
                if (listbxBrans.GetItemChecked(i) == true)
                {

                   Branslar=listbxBrans.Items[i].ToString() + "," +Branslar;

                }

            }
            string BitisTarihi = (dateTimePicker1.Value.AddDays(Int64.Parse(comboxPeriyot.Text)).ToString());
            string AlarmBaslamaTarihi= (dateTimePicker1.Value.AddDays(Int64.Parse(comboxPeriyot.Text)).ToString());
            string BaslangicTarihi = dateTimePicker1.Value.ToString();
           
        
            bool uyelikcheck = false;
            if (radiobtPlat.Checked == true)
            {
                UyelikPaketi = radiobtPlat.Text;
                uyelikcheck = true;
                uyelikfiyat = 1000;
                    
            }

            else if (radiobtGold.Checked == true)
            {
                UyelikPaketi = radiobtGold.Text;
                uyelikcheck=true;
                uyelikfiyat = 500;
            }
            else if (radiobtBronze.Checked == true)
            {
                UyelikPaketi = radiobtBronze.Text;
                uyelikcheck=!true;
                uyelikfiyat = 250;
            }
            
           

            if (comboxPeriyot.Text=="" || textbxAd.Text == "" || textbxTel.Text == "" || textbxCafe.Text == "" || textbxYas.Text == "" || uyelikcheck==false || Branslar=="" || comboxCins.Text=="")
            {

                MessageBox.Show("Eksik alan bırakmayınız");


            }
            
           
            
            else
            {

                try
                {
                    Int32.TryParse(textbxCafe.Text, out Bakiye);

                    int periyotAy = Int32.Parse(comboxPeriyot.Text) / 30;

                    tutar = periyotAy * uyelikfiyat + Bakiye;

                    baglanti.Open();
                    string query = "insert into UyeTbl (UyeAdSoyad,UyeTelefonNo,UyeCinsiyet,UyeYas,UyeBakiye,UyeBranslar,UyePeriyot,UyelikPaketi,BaslangicTarihi,BitisTarihi) values ('" + textbxAd.Text + "','" + textbxTel.Text + "','" + comboxCins.SelectedItem.ToString() + "','" + textbxYas.Text + "','"+textbxCafe.Text+"','"+Branslar+"','"+comboxPeriyot.SelectedItem+"','"+UyelikPaketi+"','"+BaslangicTarihi+"','"+BitisTarihi+"')";
                    SqlCommand komut= new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    
                    MessageBox.Show("Üye Kaydı Tamamlandı Toplam Tutar:"+tutar);
                    textbxAd.Text = "";
                    textbxCafe.Text = "";
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

                }catch(Exception Error)
                {

                    MessageBox.Show("Error.Message");


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
            AnaSayfa anasayfa = new AnaSayfa(username.Text);
            anasayfa.Show();
            this.Hide();


        }


        private void Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa(username.Text);
            anasayfa.Show();
            this.Hide();


        }

        private void picbxYeni_Click(object sender, EventArgs e)
        {

        }

        private void comboxPeriyot_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void textbxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textbxYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbxCafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbxBakiye_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
