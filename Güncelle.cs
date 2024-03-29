﻿using System;
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
using System.Runtime.InteropServices.ComTypes;

namespace proje
{
    public partial class Güncelle : Form
    {
        public Güncelle(string username)
        {
            InitializeComponent();
            this.username.Text = username;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\GYMOTOMASYONDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int eskipaketborcu { get; set; }
        string odenen { get; set; }


        string yenipaket { get; set; }
        string logodenenlerglobal { get; set; }
        int yeniperiyot { get; set; }
        int yenipktfiyat { get; set; }
        int yenipaketborcu { get; set; }
        int odemetutar { get; set; }
        int keygonder { get; set; }





        private int tutarhesapla(string paket, int periyot)
        {
            int tutar = 0;
            if (paket == "Platinum")
                tutar = 1000 * (periyot / 30);
            else if (paket == "Gold")
                tutar = 500 * (periyot / 30);
            else if (paket == "Bronze")
                tutar = 250 * (periyot / 30);
            return tutar;
        }
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






        private void Güncelle_Load(object sender, EventArgs e)
        {
            uyeGetir();
        }
        int key = 0;


        private void X_Click_1(object sender, EventArgs e)
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
        //


        private void button1_Click(object sender, EventArgs e)
        {
            if (UYEDGV.SelectedRows[0].Cells[0].Value != null)
            {
                textbxAd.Text = "";
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
                keygonder = key;
                if (key != 0)
                {

                    key = Convert.ToInt32(UYEDGV.SelectedRows[0].Cells[0].Value.ToString());
                    textbxAd.Text = UYEDGV.SelectedRows[0].Cells[1].Value.ToString();
                    textbxTel.Text = UYEDGV.SelectedRows[0].Cells[2].Value.ToString();
                    comboxCins.Text = UYEDGV.SelectedRows[0].Cells[3].Value.ToString();
                    textbxYas.Text = UYEDGV.SelectedRows[0].Cells[4].Value.ToString();
                    string branslar = UYEDGV.SelectedRows[0].Cells[6].Value.ToString();
                    comboxPeriyot.Text = UYEDGV.SelectedRows[0].Cells[7].Value.ToString();
                    string paket = UYEDGV.SelectedRows[0].Cells[8].Value.ToString();
                    string odenen = UYEDGV.SelectedRows[0].Cells[12].Value.ToString();


                    if (paket == "Platinum")
                        radiobtPlat.Checked = true;
                    else if (paket == "Gold")
                        radiobtGold.Checked = true;
                    else if (paket == "Bronze")
                        radiobtBronze.Checked = true;
                    string[] result = branslar.Split(',');


                    foreach (string str in result)
                    {

                        for (int i = 0; i <= 8; i++)
                        {

                            if (listbxBrans1.Items[i].ToString() == str)
                            {


                                listbxBrans1.SetItemChecked(i, true);
                            }
                        }

                    }
                }





            }

            else
                MessageBox.Show("Seçilecek üyeye tıklayınız");

        }


        private void btReset_Click(object sender, EventArgs e)
        {
            textbxAd.Text = "";
            textbxTel.Text = "";
            textbxYas.Text = "";
            comboxCins.Text = " ";
            comboxPeriyot.Text = " ";

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

                }
                catch (Exception Error)
                {

                    MessageBox.Show(Error.Message);

                }



            }
            uyeGetir();

        }

        private void btGunc_Click(object sender, EventArgs e)
        {

            string Branslar = "";
            for (int i = 0; i < listbxBrans1.Items.Count; i++)
            {
                if (listbxBrans1.GetItemChecked(i) == true)
                {

                    Branslar = listbxBrans1.Items[i].ToString() + "," + Branslar;

                }

            }
            int uyelikPaketÜcreti = 0;
            string UyelikPaketi = "";
            bool uyelikcheck = false;

            if (radiobtPlat.Checked == true)
            {
                UyelikPaketi = radiobtPlat.Text;
                yenipaket = UyelikPaketi;
                uyelikcheck = true;
                uyelikPaketÜcreti = 1000;
                yenipktfiyat = uyelikPaketÜcreti;

            }

            else if (radiobtGold.Checked == true)
            {
                UyelikPaketi = radiobtGold.Text;
                yenipaket = UyelikPaketi;
                uyelikcheck = true;
                uyelikPaketÜcreti = 500;
                yenipktfiyat = uyelikPaketÜcreti;
            }
            else if (radiobtBronze.Checked == true)
            {
                UyelikPaketi = radiobtBronze.Text;
                yenipaket = UyelikPaketi;
                uyelikcheck = true;
                uyelikPaketÜcreti = 250;
                yenipktfiyat = uyelikPaketÜcreti;
            }
            if (key == 0 || textbxAd.Text == "" || textbxTel.Text == "" || textbxYas.Text == "" || comboxCins.Text == "" || comboxPeriyot.Text == "" || uyelikcheck == false || Branslar == "")
            {
                MessageBox.Show("Eksik bilgi/silinecek üyeyi seçiniz");



            }


            else
            {
                try
                {
                    yeniperiyot = Convert.ToInt32(comboxPeriyot.Text);


                    baglanti.Open();

                    string query = "update UyeTbl set UyeAdSoyad='" + textbxAd.Text + "',UyeTelefonNo='" + textbxTel.Text + "' ,UyeCinsiyet='" + comboxCins.SelectedItem.ToString() + "' ,UyeYas='" + textbxYas.Text + "',UyeBranslar='" + Branslar + "', UyePeriyot='" + comboxPeriyot.SelectedItem + "' ,UyelikPaketi='" + UyelikPaketi + "' where UyeId=" + key + ";";
                    string okumaquery = "select * from UyeTbl where UyeId=" + key + ";";
                    // SqlCommand command = new SqlCommand(okumaquery,baglanti);
                    using (SqlCommand command = new SqlCommand(okumaquery, baglanti))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {


                                DateTime now = DateTime.Now;

                                string log = (reader["log"].ToString());
                                string tarih = reader["BaslangicTarihi"].ToString();
                                string eskipaket = reader["UyelikPaketi"].ToString();
                                int eskiperiyot = Convert.ToInt32(reader["UyePeriyot"].ToString());
                                int paketborcu = Convert.ToInt32(reader["paketborcu"].ToString());
                                eskipaketborcu = paketborcu;
                                string logodemeler = reader["logUyePaketOdemeler"].ToString();
                                logodenenlerglobal = logodemeler;
                                double eskitutar = 0;
                                double günlükücret = 0;
                                double hakediş;
                                double total;
                                double ödenen = 0;

                                if(yenipaket== eskipaket && yeniperiyot== eskiperiyot)
                                {



                                }



                                else { 

                                if (eskipaket == "Platinum")
                                {
                                    eskitutar = 1000 * (eskiperiyot / 30);
                                    günlükücret = 1000 / 30;
                                }
                                else if (eskipaket == "Gold")
                                {
                                    eskitutar = 500 * (eskiperiyot / 30);
                                    günlükücret = 500 / 30;

                                }
                                else if (eskipaket == "Bronze")
                                {
                                    eskitutar = 250 * (eskiperiyot / 30);
                                    günlükücret = 250 / 30;
                                }
                                DateTime baslangic = DateTime.Parse(tarih);
                                TimeSpan days = now - baslangic;
                                    string yenibaslangic = DateTime.Now.ToString("dd,MM,yyyy");
                                   DateTime yenibitistarihi= DateTime.Now.AddDays(Int32.Parse(comboxPeriyot.Text));
                                    string stryenibitistarihi = yenibitistarihi.ToString("dd,MM,yyyy");
                                    double nrOfDays = days.TotalDays;
                                hakediş = nrOfDays * günlükücret;
                                double yenitutar = yenipktfiyat * yeniperiyot / 30;
                                ödenen = eskitutar - Math.Abs(paketborcu);
                                total = ödenen - hakediş - yenitutar;
                                int Yenipaketborcu = Convert.ToInt32(total);
                                if (Yenipaketborcu < 0)
                                {
                                    MessageBox.Show("Yeni Tutar " + (-Yenipaketborcu));
                                    yenipaketborcu = Yenipaketborcu;

                                    int degisim = Math.Abs(eskipaketborcu) + Yenipaketborcu;

                                    logodenenlerglobal = "," + logodenenlerglobal + now + " " + username.Text + " Paket ve/veya periyot değişim sebebiyle yansıyan fark  " + Math.Abs(degisim);

                                }
                                else if (Yenipaketborcu > 0)
                                {
                                    MessageBox.Show("İade Tutarı " + Yenipaketborcu);
                                    logodenenlerglobal = " , " + logodenenlerglobal + now + " " + username.Text + " Paket ve/veya periyot değişim sebebiyle iade edilen tutar " + Yenipaketborcu;
                                    Yenipaketborcu = 0;
                                    yenipaketborcu = Yenipaketborcu;


                                }





                                log += now.ToString() + " " + username.Text + " güncelle,";

                                SqlConnection baglanti2 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YUSUF\DOCUMENTS\GYMOTOMASYONDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                                string logson = "update UyeTbl set log='" + log + "',paketborcu='" + yenipaketborcu + "',BaslangicTarihi='" + yenibaslangic + "' ,BitisTarihi='" + stryenibitistarihi + "',logUyePaketOdemeler='" + logodenenlerglobal + "' where UyeId=" + key + ";";
                                baglanti2.Open();
                                SqlCommand logyaz = new SqlCommand(logson, baglanti2);
                                logyaz.ExecuteNonQuery();
                                baglanti2.Close();
                            }

                        }
                    }
                        SqlCommand komut = new SqlCommand(query, baglanti);


                        komut.ExecuteNonQuery();


                        odemetutar = tutarhesapla(yenipaket, yeniperiyot) - Convert.ToInt32(odenen);



                        MessageBox.Show("Üye Güncellendi");
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

        private void textbxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textbxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbxYas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbxBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
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