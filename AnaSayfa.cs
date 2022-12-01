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
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace proje
{
    public partial class AnaSayfa : Form
    {
        
        public AnaSayfa(string username)
        {
            InitializeComponent();
            uyeGetir();
            this.username.Text = username; 
        }

        void fonksiyon()
        {
            


            using (SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\DATABASESALON.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            using (SqlCommand command = new SqlCommand("select * from UyeTbl", baglanti))
            {
                baglanti.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string Alarm = "";
                    while (reader.Read())
                    {
                        DateTime Kontrol = DateTime.Now.AddDays(4);
                        string Kontrols = Kontrol.ToString("dd.MM.yyyy");
                        Kontrol = Convert.ToDateTime(Kontrols);

                        string BitisTarihis = (reader["BitisTarihi"].ToString());
                        DateTime BitisTarihi = Convert.ToDateTime(BitisTarihis);
                        BitisTarihis = BitisTarihi.ToString("dd.MM.yyyy");
                        int result = DateTime.Compare(BitisTarihi, Kontrol);
                        if (result < 0 || result == 0)
                        {
                            string ad = (reader["UyeAdSoyad"].ToString());
                            string ÜyeSon = BitisTarihi.Subtract(DateTime.Now).ToString();
                            string increment = string.Format("{0}  Bitiş Tarihi: {1}\n", ad, BitisTarihis);
                            Alarm += increment;
                        }

                        else
                        {



                        }
                    }
                    alarmbx.Text = Alarm;
                }
            }


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



        private void button3_Click(object sender, EventArgs e)
        {
            ÜyeEkle uyeekle = new ÜyeEkle(username.Text);
            uyeekle.Show();
            this.Hide();
            
        }

        private void UyeEkle_Click(object sender, EventArgs e)
        {
            Güncelle güncelle=new Güncelle(username.Text);
            güncelle.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme(username.Text);
            odeme.Show();
            this.Hide();
        }

        int key = 0;

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textbxCafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            key=Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[0].Value.ToString());
            if (key == 0 || textbxCafe.Text == "")
            {
                MessageBox.Show("Alışveriş yapan üyeyi seçiniz - alışveriş tutarını giriniz");



            }
            else
            {
                try
                {

                    baglanti.Open();
                    string streskibakiye = UYEDGV.SelectedRows[0].Cells[5].Value.ToString();
                    int YeniBakiye = Convert.ToInt32(streskibakiye)-Convert.ToInt32(textbxCafe.Text);
                    string query = "update UyeTbl set UyeBakiye='" +YeniBakiye+"' where UyeId=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery(); 
                    baglanti.Close();
                    uyeGetir();
                    key = Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[0].Value.ToString());
                    string Yenibakiye = UYEDGV.SelectedRows[0].Cells[5].Value.ToString();
                    MessageBox.Show("Ödeme Başarılı Yeni Bakiye "+Yenibakiye);
                  

                }
                catch (Exception Error)
                {

                    MessageBox.Show(Error.Message);

                }



            }
            uyeGetir();
            key = 0;
        }

        private void btara_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                uyeGetir();
            else
                isimleAra();
        }
    }
    }
    

