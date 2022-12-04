using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proje
{
    public partial class Odeme : Form
    {
        int key { get; set; }

        public Odeme(string username)
        {
            InitializeComponent();
            uyeGetir();
            this.username.Text = username;
           

        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void Borcgetir()
        {


            if (key != 0)
            {
                int borc;
                key = Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[0].Value.ToString());
                borc = Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[12].Value.ToString());
                if (borc < 0)
                    borc = -borc;
                textbxUyelik.Text = borc.ToString() + " TL";
                textbxbakiye.Text = UYEDGV.SelectedRows[0].Cells[5].Value.ToString();

            }


        }
        private void isimleAra()
        {
            baglanti.Open();
            string query = "select *from UyeTbl where UyeAdSoyad= '" + textbxAd.Text + "'";
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
            if (key == 0)
                MessageBox.Show("Üyeyi seçin");
            else
            {
                if (radiobtCafe.Checked)
                {

                    SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    baglanti.Open();
                    string okumaquery = "select * from UyeTbl where UyeId=" + key + ";";
                    using (SqlCommand command = new SqlCommand(okumaquery, baglanti))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {



                                DateTime tarih = dateTimePicker1.Value;
                                string streskibakiye = (reader["UyeBakiye"].ToString());
                                string log = reader["logUyeBakiye"].ToString();
                                int eskibakiye = Convert.ToInt32(streskibakiye);
                                int yenibakiye = eskibakiye + Convert.ToInt32(textbxTutar.Text);
                               

                                log = log + "," + tarih + "  " + username.Text + "+" + textbxTutar.Text + " TL Bakiye Ödemesi";

                                SqlConnection baglanti2 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                string logson = "update UyeTbl set logUyeBakiye='" + log + "' ,UyeBakiye='" + yenibakiye + "' where UyeId=" + key + ";";
                                baglanti2.Open();
                                SqlCommand logyaz = new SqlCommand(logson, baglanti2);
                                logyaz.ExecuteNonQuery();
                                MessageBox.Show("Ödeme Yapıldı");
                                baglanti2.Close();
                            }
                        }

                    }


                    uyeGetir();


                }

                else if (radiobtUyelik.Checked)
                {

                    SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    baglanti.Open();
                    string okumaquery = "select * from UyeTbl where UyeId=" + key + ";";
                    using (SqlCommand command = new SqlCommand(okumaquery, baglanti))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {


                                DateTime tarih = dateTimePicker1.Value;
                                string streskiborc= (reader["paketborcu"].ToString());
                                string log = reader["logUyePaketOdemeler"].ToString();
                                int eskiborc = Convert.ToInt32(streskiborc);
                                int yeniborc = eskiborc + Convert.ToInt32(textbxTutar.Text);

                                if (Math.Abs(eskiborc) > Convert.ToInt32(textbxTutar.Text) || Math.Abs(eskiborc) == Convert.ToInt32(textbxTutar.Text))
                                {

                                    log = log + " , " + tarih + "  " + username.Text + "  " + textbxTutar.Text + " TL Üyelik ücreti ödemesi";

                                    SqlConnection baglanti2 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                    string logson = "update UyeTbl set logUyePaketOdemeler='" + log + "' ,paketborcu='" + yeniborc + "' where UyeId=" + key + ";";
                                    baglanti2.Open();
                                    SqlCommand logyaz = new SqlCommand(logson, baglanti2);
                                    logyaz.ExecuteNonQuery();
                                    MessageBox.Show("Ödeme Yapıldı");
                                    baglanti2.Close();
                                }

                                else
                                    MessageBox.Show("Borç miktarından daha fazla ödeme yapılamaz");
                            }
                        }

                    }


                    uyeGetir();






                }

                else
                    MessageBox.Show("Ödeme türünü seçiniz");







                uyeGetir();

                Borcgetir();
            }
        }

        private void btborcgetir_Click(object sender, EventArgs e)
        {
            if (UYEDGV.SelectedRows[0].Cells[0].Value != null)
            {
                key = 0;
                key = Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[0].Value.ToString());
                if (key == 0)
                    MessageBox.Show("Üyeyi seçin");
                else
                {
                    
                    Borcgetir();
                }



            }

             else
                MessageBox.Show("Üyeyi seçin");

        }
            
            
            private void arabt_Click(object sender, EventArgs e)
            {
            if(textbxAd.Text == "")
                uyeGetir();
            else
                isimleAra();
        }

        private void textbxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
    }

