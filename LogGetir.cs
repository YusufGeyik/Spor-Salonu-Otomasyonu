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
    public partial class LogGetir : Form
    {
        public LogGetir(string username)
        {
            InitializeComponent();
            this.username.Text = username;
            uyeGetir();
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

        private void LogGetir_Load(object sender, EventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int key = 0;

            if (UYEDGV.SelectedRows[0].Cells[0].Value != null)
            {
                key = 0;
                key = Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[0].Value.ToString());
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




                                    string logs = reader["logUyeBakiye"].ToString();
                                    string[] loglist = logs.Split(',');
                                    logs = "";
                                    foreach (string log in loglist)
                                        logs += log + "\n";
                                    richTextBox1.Text = logs;

                                    

                                }
                            }

                        }
                        baglanti.Close();


                    }

                    else if (radiobtUyelik.Checked)
                    {

                        baglanti.Open();
                        string okumaquery = "select * from UyeTbl where UyeId=" + key + ";";
                        using (SqlCommand command = new SqlCommand(okumaquery, baglanti))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                while (reader.Read())
                                {




                                    string logs = reader["logUyePaketOdemeler"].ToString();
                                    string[] loglist = logs.Split(',');
                                    logs = "";
                                    foreach (string log in loglist)
                                        logs += log + "\n";
                                    richTextBox1.Text = logs;



                                }
                            }


                            

                        }
                        baglanti.Close();
                    }

                    else if (radiobtUI.Checked)
                    {
                        baglanti.Open();
                        string okumaquery = "select * from UyeTbl where UyeId=" + key + ";";
                        using (SqlCommand command = new SqlCommand(okumaquery, baglanti))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {

                                while (reader.Read())
                                {




                                    string logs = reader["log"].ToString();
                                    string[] loglist = logs.Split(',');
                                    logs = "";
                                    foreach (string log in loglist)
                                       
                                        logs += log + "\n";
                                    richTextBox1.Text = logs;
                                   


                                }
                            }

                        }
                        baglanti.Close();
                    }

                    else
                        MessageBox.Show("İşlem geçmişi türünü seç");



                }



            }

            else
                MessageBox.Show("Üyeyi seçin");

        }

        private void btara_Click(object sender, EventArgs e)
        {

        }
    }
}

