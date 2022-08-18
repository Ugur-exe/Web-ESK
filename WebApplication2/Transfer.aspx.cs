using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-U0HV2JK;Initial Catalog=ESK;Integrated Security=True");
        SqlCommand komut;
        string transfer;
        int ankarabuyuk,ankarakucuk,ankarakanatli,erzincankanatli,erzincanbuyuk,erzincankucuk;
        
        DateTime zaman = DateTime.Now;
        string format = "yyyy-MM-dd";
        void ServerCikar(string a, string b)
        {
            var zamanim = zaman.ToString(format);
            ankarabuyuk=ankarabuyuk-Convert.ToInt32(b);
            baglanti.Open();
            komut = new SqlCommand(a, baglanti);
            komut.Parameters.AddWithValue("@Adet", ankarabuyuk);
            komut.Parameters.AddWithValue("@Tarih", zamanim);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }void ServerEkle(string a, string b)
        {
            var zamanim = zaman.ToString(format);
            erzincanbuyuk = erzincanbuyuk + Convert.ToInt32(b);
            baglanti.Open();
            komut = new SqlCommand(a, baglanti);
            komut.Parameters.AddWithValue("@Adet", erzincanbuyuk);
            komut.Parameters.AddWithValue("@Tarih", zamanim);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        void Transfer(string a, string b)
        {
            var zamanim = zaman.ToString(format);
            baglanti.Open();
            komut = new SqlCommand(a, baglanti);
            komut.Parameters.AddWithValue("@" + transfer + "", Convert.ToInt32(b));
            komut.Parameters.AddWithValue("@Tarih", zamanim);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        void Ankarab()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From AnkaraBuyuk ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ankarabuyuk = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void Ankarak()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From AnkaraKucuk ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ankarakucuk = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();

        }
        void Ankarakanat()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From AnkaraKanatli ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ankarakanatli = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox1.Checked)
            {
                TextBox1.Enabled = true;
                TextBox2.Enabled = false;
                CheckBox2.Checked = false;
            }
            else if (CheckBox1.Checked==false &&CheckBox2.Checked==false)
            {
                TextBox1.Enabled = true;
                TextBox2.Enabled = true;
            }
           
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                TextBox1.Enabled = false;
                TextBox2.Enabled = true;
            }
            else if (CheckBox1.Checked == false && CheckBox2.Checked == false)
            {
                TextBox1.Enabled = true;
                TextBox2.Enabled = true;
            }
        }

        void ErzincanB()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From ErzincanBuyuk  ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                erzincanbuyuk = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void ErzincanK()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From ErzincanKucuk  ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                erzincankucuk = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void ErzincanKanat()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From ErzincanKanatli  ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                erzincankanatli = Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Kullanici"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            ErzincanB(); ErzincanK(); ErzincanKanat(); Ankarab(); Ankarak(); Ankarakanat();

        } 
        protected void Button9_Click(object sender, EventArgs e)
        {
            var zamanim = zaman.ToString(format);
            if (TextBox1.Text == "" && TextBox2.Text == "")
            {
                Response.Write("<script lang='JavaScript'>alert('Kutular Boş Geçilemez');</script>");
            }
            else
            {
                if (CheckBox1.Checked == true && CheckBox2.Checked == true)
                {
                    Response.Write("<script lang='JavaScript'>alert('Sadece Bir Kombina Seçilebilir');</script>");
                }
                else
                {
                    if (CheckBox1.Checked)
                    {
                        try
                        {
                            if (RadioButtonList1.SelectedItem.Value == "Büyük Baş")
                            {
                                ServerCikar("Update AnkaraBuyuk Set Adet=@Adet Where Tarih=@Tarih", TextBox1.Text);
                                ServerEkle("Update  ErzincanBuyuk Set Adet=@Adet Where Tarih=@Tarih", TextBox1.Text);
                                transfer = "BuyukBas";
                                Transfer("Insert Into Transfer (Tarih,BuyukBas) values(@Tarih,@Buyukbas)",TextBox1.Text);
                            }
                            else if (RadioButtonList1.SelectedItem.Value == "Küçük Baş")
                            {
                                ServerCikar("Update AnkaraKucuk Set Adet=@Adet Where Tarih=@Tarih", TextBox1.Text);
                                ServerEkle("Update  ErzincanKucuk Set Adet=@Adet Where Tarih=@Tarih", TextBox1.Text);
                                transfer = "KucukBas";
                                Transfer("Insert Into Transfer (Tarih,KucukBas) values(@Tarih,@Kucukbas)", TextBox1.Text);
                            }
                            else if (RadioButtonList1.SelectedItem.Value == "Kanatlı")
                            {
                                ServerCikar("Update AnkaraKanatli Set Adet=@Adet Where Tarih=@Tarih", TextBox1.Text);
                                ServerEkle("Update  ErzincanKanatli Set Adet=@Adet Where Tarih=@Tarih", TextBox1.Text);
                                transfer = "Kanatli";
                                Transfer("Insert Into Transfer (Tarih,Kanatli) values(@Tarih,@Kanatli)", TextBox1.Text);
                            }

                        }
                        catch (Exception)
                        {
                            Response.Write("<script lang='JavaScript'>alert('Lütfen Bir İşlem Seçin !');</script>");
                        }
                        
                    }
                    else if (CheckBox2.Checked)
                    {
                        try
                        {
                            if (RadioButtonList1.SelectedItem.Value == "Büyük Baş")
                            {
                                ServerEkle("Update AnkaraBuyuk Set Adet=@Adet Where Tarih=@Tarih", TextBox2.Text);
                                ServerCikar("Update  ErzincanBuyuk Set Adet=@Adet Where Tarih=@Tarih", TextBox2.Text);
                                transfer = "BuyukBas";
                                Transfer("Insert Into Transfer (Tarih,BuyukBas) values(@Tarih,@Buyukbas)", TextBox2.Text);

                            }
                            else if (RadioButtonList1.SelectedItem.Value == "Küçük Baş")
                            {
                                ServerEkle("Update AnkaraKucuk Set Adet=@Adet Where Tarih=@Tarih", TextBox2.Text);
                                ServerCikar("Update  ErzincanKucuk Set Adet=@Adet Where Tarih=@Tarih", TextBox2.Text);
                                transfer = "KucukBas";
                                Transfer("Insert Into Transfer (Tarih,KucukBas) values(@Tarih,@Kucukbas)", TextBox2.Text);
                            }
                            else if (RadioButtonList1.SelectedItem.Value == "Kanatlı")
                            {
                                ServerEkle("Update AnkaraKanatli Set Adet=@Adet Where Tarih=@Tarih", TextBox2.Text);
                                ServerCikar("Update  ErzincanKanatli Set Adet=@Adet Where Tarih=@Tarih", TextBox2.Text);
                                transfer = "Kanatli";
                                Transfer("Insert Into Transfer (Tarih,Kanatli) values(@Tarih,@Kanatli)", TextBox2.Text);
                            }
                            else
                            {
                                Response.Write("<script lang='JavaScript'>alert('Lütfen Bir İşlem Seçin !');</script>");
                            }

                        }
                        catch (Exception)
                        {
                            Response.Write("<script lang='JavaScript'>alert('Lütfen Bir İşlem Seçin !');</script>");
                        }
                        
                    }
                    else
                    {
                        Response.Write("<script lang='JavaScript'>alert('Lütfen Bir Kombina Seçin !');</script>");
                    }
                }
                TextBox1.Text = ""; TextBox2.Text = "";
            }
        }
    }
}