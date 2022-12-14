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
        int keygonder { get; set; }
        string paket { get; set; }

        public ÜyeEkle(string username)
        {
            InitializeComponent();
            this.username.Text = username;

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\GYMOTOMASYONDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        
           
       public int tutarsakla { get; set; }


        private void button2_Click(object sender, EventArgs e)
        {
            textbxAd.Text = ""; 
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
         
            int Bakiye=0;
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
            string BitisTarihi = (dateTimePicker1.Value.AddDays(Int64.Parse(comboxPeriyot.Text)).ToString("dd.MM.yyyy"));
            string AlarmBaslamaTarihi= (dateTimePicker1.Value.AddDays(Int64.Parse(comboxPeriyot.Text)).ToString());
            string BaslangicTarihi = dateTimePicker1.Value.ToString("dd.MM.yyyy");
           
        
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
            
           

            if (comboxPeriyot.Text=="" || textbxAd.Text == "" || textbxTel.Text == "" || textbxYas.Text == "" || uyelikcheck==false || Branslar=="" || comboxCins.Text=="")
            {

                MessageBox.Show("Eksik alan bırakmayınız");


            }
            
           
            
            else
            {

                try
                {

                    string lUyePaketOdemeler = "";
                    string UyeBakiye = "";
                    int periyotAy = Int32.Parse(comboxPeriyot.Text) / 30;
                    int odenenmiktar = 0;
                    tutar = periyotAy * uyelikfiyat;
                    string log =BaslangicTarihi.ToString()+" "+username.Text + "  üye ekle,";
                    baglanti.Open();
                    
                    
                    string query = "insert into UyeTbl (UyeAdSoyad,UyeTelefonNo,UyeCinsiyet,UyeYas,UyeBakiye,UyeBranslar,UyePeriyot,UyelikPaketi,BaslangicTarihi,BitisTarihi,log,paketborcu,logUyePaketOdemeler,logUyeBakiye) values ('" + textbxAd.Text + "','" + textbxTel.Text + "','" + comboxCins.Text + "','" + textbxYas.Text + "','"+Bakiye+"','"+Branslar+"','"+comboxPeriyot.SelectedItem+"','"+UyelikPaketi+"','"+BaslangicTarihi+"','"+BitisTarihi+"','"+log+ "','"+-tutar+"','"+lUyePaketOdemeler+"','"+UyeBakiye+"')";
                    SqlCommand komut= new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    
                    MessageBox.Show("Üye Kaydı Tamamlandı Toplam Tutar:"+tutar);
                    tutarsakla = tutar;
                    textbxAd.Text = "";
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

       
    }
}
