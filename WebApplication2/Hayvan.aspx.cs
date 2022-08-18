using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-U0HV2JK;Initial Catalog=ESK;Integrated Security=True");
        SqlCommand komuta;
        
        
        DateTime zaman = DateTime.Now;
        string format = "yyyy-MM-dd";
        int ankarabuyuk, ankarakucuk, ankarakanatli, erzincankanatli, erzincanbuyuk, erzincankucuk;
        
        double ankaraB, ankaraK, ankaraKanat, erzincanB, erzincanK, erzincanKanat;

        void Sil()
        {
            TextBox1.Text = ""; TextBox11.Text = ""; TextBox5.Text = ""; TextBox6.Text = ""; TextBox9.Text = ""; TextBox10.Text = "";
        }
        void ServerEkle(string a,string b,string c)
        {
            var zamanim = zaman.ToString(format);
            baglanti.Open();
            komuta = new SqlCommand(a, baglanti);
            komuta.Parameters.AddWithValue("@Adet", Convert.ToInt32(b));
            komuta.Parameters.AddWithValue("@Fiyat", c);
            komuta.Parameters.AddWithValue("@Tarih", zamanim);
            komuta.ExecuteNonQuery();
            baglanti.Close();
        }
        void ServerGuncelle(string a,string b,string c)
        {
            var zamanim = zaman.ToString(format);
            komuta = new SqlCommand(a, baglanti);
            komuta.Parameters.AddWithValue("@Adet",Convert.ToInt32(b));
            komuta.Parameters.AddWithValue("@Fiyat", Convert.ToDouble(c));
            komuta.Parameters.AddWithValue("@Tarih", zamanim);
            komuta.ExecuteNonQuery();
            baglanti.Close();

        }
        void Ankarab()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From AnkaraBuyuk ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ankarabuyuk = Convert.ToInt32(oku["Adet"]);
             
                ankaraB = Convert.ToDouble(oku["Fiyat"]);
                
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
               
                ankaraK = Convert.ToDouble(oku["Fiyat"]);
            }
            baglanti.Close();

        }void Ankarakanat()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From AnkaraKanatli ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ankarakanatli = Convert.ToInt32(oku[0]);
                
                ankaraKanat = Convert.ToDouble(oku["Fiyat"]);
            }
            baglanti.Close();
        }
        void ErzincanB()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From ErzincanBuyuk  ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                erzincanbuyuk = Convert.ToInt32(oku[0]);
                
                erzincanB = Convert.ToDouble(oku["Fiyat"]);
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
               
                erzincanK = Convert.ToDouble(oku["Fiyat"]);
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
                
                erzincanKanat = Convert.ToDouble(oku["Fiyat"]);
            }
            baglanti.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
             
            if (Session["Kullanici"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            ErzincanB();ErzincanK();ErzincanKanat();Ankarab();Ankarak();Ankarakanat();
            
            
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            var zamanim = zaman.ToString(format);
            if (CheckBox2.Checked == true && CheckBox1.Checked == true)
            {
                Response.Write("<script lang='JavaScript'>alert('Sadece Bir Kombina Seçilebilir');</script>");
            }
            else
            {
                if (TextBox1.Text == "" || TextBox11.Text == "")
                {
                    Response.Write("<script lang='JavaScript'>alert('Tüm Alanlar Doldurulmalıdır!');</script>");
                }
                else
                {
                    if (CheckBox1.Checked)
                    {
                        try
                        {
                            
                            ServerEkle("Insert Into AnkaraBuyuk (Adet,Fiyat,Tarih) values(@Adet,@Fiyat,@Tarih)", TextBox1.Text,TextBox11.Text);
                            Sil();
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");

                        }
                        catch (Exception)
                        {
                            int a = ankarabuyuk + Convert.ToInt32(TextBox1.Text);
                            double b = ankaraB + Convert.ToDouble(TextBox11.Text);
                            ServerGuncelle("Update AnkaraBuyuk Set Adet=@Adet,Fiyat=@Fiyat Where Tarih=@Tarih", Convert.ToString(a),Convert.ToString(b));
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                            Sil();
                        }
                        
                    }
                    else if (CheckBox2.Checked)
                    {
                        try
                        {
                            ServerEkle("Insert Into ErzincanBuyuk (Adet,Fiyat,Tarih) values(@Adet,@Fiyat,@Tarih)", TextBox1.Text, TextBox11.Text);
                            Sil();
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                        }
                        catch (Exception)
                        {
                            int a = erzincanbuyuk + Convert.ToInt32(TextBox1.Text);
                            double b = erzincanB+ Convert.ToDouble(TextBox6.Text);
                            ServerGuncelle("Update ErzincanBuyuk Set Adet=@Adet,Fiyat=@Fiyat Where Tarih=@Tarih", Convert.ToString(a), Convert.ToString(b));
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                            Sil();
                        }
                    }
                    else
                    {
                        Label5.Text = "Bir Kombina Seçiniz !";
                    }

                }
            }   
            
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            var zamanim = zaman.ToString(format);
            if (CheckBox2.Checked == true && CheckBox1.Checked == true)
            {
                Response.Write("<script lang='JavaScript'>alert('Sadece Bir Kombina Seçilebilir');</script>");
            }
            else
            {
                if (TextBox5.Text == "" || TextBox6.Text == "")
                {
                    Response.Write("<script lang='JavaScript'>alert('Tüm Alanlar Doldurulmalıdır!');</script>");
                }
                else
                {
                    if (CheckBox1.Checked)
                    {
                        try
                        {
                            ServerEkle("Insert Into AnkaraKucuk (Adet,Fiyat,Tarih) values(@Adet,@Fiyat,@Tarih)", TextBox5.Text, TextBox6.Text);
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                            Sil();

                        }
                        catch (Exception)
                        {
                            int a = ankarakucuk + Convert.ToInt32(TextBox5.Text);
                            double b=ankaraK+Convert.ToDouble(TextBox6.Text);
                            ServerGuncelle("Update AnkaraKucuk Set Adet=@Adet,Fiyat=@Fiyat Where Tarih=@Tarih", Convert.ToString(a), Convert.ToString(b));
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                            Sil();
                        }
                    }
                    else if (CheckBox2.Checked)
                    {
                        try
                        {
                            ServerEkle("Insert Into ErzincanKucuk (Adet,Fiyat,Tarih) values(@Adet,@Fiyat,@Tarih)", TextBox5.Text, TextBox6.Text);
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                            Sil();
                        }
                        catch (Exception)
                        {
                            int a = erzincankucuk + Convert.ToInt32(TextBox5.Text);
                            double b = erzincanK + Convert.ToDouble(TextBox6.Text);
                            ServerGuncelle("Update ErzincanKucuk Set Adet=@Adet,Fiyat=@Fiyat Where Tarih=@Tarih", Convert.ToString(a), Convert.ToString(b));
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                            Sil();
                        }
                    }
                    else
                    {
                        Label6.Text = "Bir Kombina Seçiniz !";
                    }
                }
            }  
           
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            var zamanim = zaman.ToString(format);
            if (CheckBox2.Checked == true && CheckBox1.Checked == true)
            {
                Response.Write("<script lang='JavaScript'>alert('Sadece Bir Kombina Seçilebilir');</script>");
            }
            else
            {
                if (TextBox9.Text == "" || TextBox10.Text == "")
                {
                    Response.Write("<script lang='JavaScript'>alert('Tüm Alanlar Doldurulmalıdır!');</script>");
                }
                else
                {
                    if (CheckBox1.Checked)
                    {
                        try
                        {
                            ServerEkle("Insert Into AnkaraKanatli (Adet,Fiyat,Tarih) values(@Adet,@Fiyat,@Tarih)", TextBox9.Text, TextBox10.Text);
                            Sil();
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                        }
                        catch (Exception)
                        {
                            int a = ankarakanatli + Convert.ToInt32(TextBox9.Text);
                            double b = ankaraKanat + Convert.ToDouble(TextBox10.Text);
                            ServerGuncelle("Update AnkaraKanatli Set Adet=@Adet,Fiyat=@Fiyat Where Tarih=@Tarih", Convert.ToString(a), Convert.ToString(b));
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                            Sil();
                        }
                    }
                    else if (CheckBox2.Checked)
                    {
                        try
                        {
                            ServerEkle("Insert Into ErzincanKanatli (Adet,Fiyat,Tarih) values(@Adet,@Fiyat,@Tarih)", TextBox9.Text, TextBox10.Text);
                            Sil();
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                        }
                        catch (Exception)
                        {
                            int a = erzincankanatli + Convert.ToInt32(TextBox9.Text);
                            double b = erzincanKanat + Convert.ToDouble(TextBox10.Text);
                            ServerGuncelle("Update ErzincanKanatli Set Adet=@Adet,Fiyat=@Fiyat Where Tarih=@Tarih", Convert.ToString(a), Convert.ToString(b));
                            Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                            Sil();
                        }
                    }
                    else
                    {
                        Label7.Text = "Bir Kombina Seçiniz !";
                    }
                }
            }
            
        }

      
    }
}