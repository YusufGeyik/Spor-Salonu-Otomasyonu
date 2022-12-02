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

namespace proje
{
    public partial class Uyelikyenile : Form
    {
        public Uyelikyenile(string username)
        {
            InitializeComponent();
            uyeGetir(); 
            this.username.Text = username;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void isimleAra()
        {
            baglanti.Open();
            string query = "select *from UyeTbl where UyeAdSoyad= '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            UYEDGV.DataSource = ds.Tables[0];

            baglanti.Close();





        }
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

        private void btara_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                uyeGetir();
            else
                isimleAra();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btGunc_Click(object sender, EventArgs e)
        {
           int key = Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[0].Value.ToString());
            string UyelikPaketi = "";
            bool uyelikcheck = false;
            int uyelikfiyat=0;
            if (radiobtPlat.Checked == true)
            {
                UyelikPaketi = radiobtPlat.Text;
                uyelikcheck = true;
                uyelikfiyat = 1000;

            }

            else if (radiobtGold.Checked == true)
            {
                UyelikPaketi = radiobtGold.Text;
                uyelikcheck = true;
                uyelikfiyat = 500;
            }
            else if (radiobtBronze.Checked == true)
            {
                UyelikPaketi = radiobtBronze.Text;
                uyelikcheck = !true;
                uyelikfiyat = 250;
            }

            if (key == 0 || comboxPeriyot.Text == "" || uyelikcheck == false )
            {
                MessageBox.Show("Eksik bilgi/üyelik yenileyecek üyeyi seçiniz");



            }

            else
            {
                try
                {
                    int tutar;
                    int periyotAy = Int32.Parse(comboxPeriyot.Text) / 30;
                    int odenenmiktar = 0;
                    tutar = periyotAy*uyelikfiyat;
                    DateTime baslangictarihi = DateTime.Now;
                    DateTime bitistarihi = DateTime.Now.AddDays(Int32.Parse(comboxPeriyot.Text));
                    string strbaslangictarihi=baslangictarihi.ToString("dd.MM.yyyy");
                    string strbitistarihi = bitistarihi.ToString("dd.MM.yyyy"); 
                    baglanti.Open();
                    MessageBox.Show("Üyelik yenilendi. Tutar="+tutar);
                    string query = "update UyeTbl set UyePeriyot='" + comboxPeriyot.SelectedItem + "' ,UyelikPaketi='" + UyelikPaketi + "',odenenmiktar='" + odenenmiktar + "',BaslangicTarihi='" + strbaslangictarihi + "',BitisTarihi='" + strbitistarihi + "' where UyeId=" + key + ";";
                    string okumaquery = "select * from UyeTbl where UyeId=" + key + ";";
                   
                    using (SqlCommand command = new SqlCommand(okumaquery, baglanti))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {




                                string log = (reader["log"].ToString());

                                log +=baslangictarihi.ToString() + " " + username.Text + " üyelik yenile," ;

                                SqlConnection baglanti2 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                string logson = "update UyeTbl set log='" + log + "' where UyeId=" + key + ";";
                                baglanti2.Open();
                                SqlCommand logyaz = new SqlCommand(logson, baglanti2);
                                logyaz.ExecuteNonQuery();
                                baglanti2.Close();
                            }

                        }

                        SqlCommand komut = new SqlCommand(query, baglanti);


                        komut.ExecuteNonQuery();
                        
                        baglanti.Close();

                    }
                }
                catch (Exception Error)
                {

                    MessageBox.Show(Error.Message);

                }



            }
            uyeGetir();
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

    
    }
    }

