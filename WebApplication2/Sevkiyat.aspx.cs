using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DateTime zaman = DateTime.Now;
        string format = "yyyy-MM-dd";
        string tablo;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-U0HV2JK;Initial Catalog=ESK;Integrated Security=True");
        SqlCommand komut;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }
        void Sil()
        {
            TextBox1.Text = "";TextBox8.Text = "";TextBox5.Text = "";TextBox7.Text = "";
        }
        void Ekle(string a,string b,string c)
        {
            var zamanim = zaman.ToString(format);
            baglanti.Open();
            komut = new SqlCommand(a, baglanti);
            komut.Parameters.AddWithValue("@"+tablo+"", Convert.ToInt32(b));
            komut.Parameters.AddWithValue("@Arac",Convert.ToInt32(c));
            komut.Parameters.AddWithValue("@Tarih",zamanim);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox5.Text == "")
                {
                    Response.Write("<script lang='JavaScript'>alert('Araç Sayısı Giriniz !');</script>");
                }
                else
                {
                    if (RadioButtonList2.SelectedItem.Value == "Büyük Baş")
                    {
                        tablo = "AnkaraBuyukBas";
                        Ekle("Insert Into Sevkiyat (AnkaraBuyukBas,Arac,Tarih) values(@AnkaraBuyukBas,@Arac,@Tarih)", TextBox1.Text, TextBox5.Text);
                        Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                    }
                    else if (RadioButtonList2.SelectedItem.Value == "Küçük Baş")
                    {
                        tablo = "AnkaraKucukBas";
                        Ekle("Insert Into Sevkiyat (AnkaraKucukBas,Arac,Tarih) values(@AnkaraKucukBas,@Arac,@Tarih)", TextBox1.Text, TextBox5.Text);
                        Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                    }
                    else if (RadioButtonList2.SelectedItem.Value == "Kanatlı")
                    {
                        tablo = "AnkaraKanatli";
                        Ekle("Insert Into Sevkiyat (AnkaraKanatli,Arac,Tarih) values(@AnkaraKanatli,@Arac,@Tarih)", TextBox1.Text, TextBox5.Text);
                        Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                    }
                    Sil();
                    Label9.Text = "";
                }
                
            }
            catch (Exception)
            {
                Label9.Text = "Tüm Alanlar Doldurulmalıdır!";
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox7.Text=="" ||TextBox8.Text==""||RadioButtonList3.Text=="")
                {
                    Response.Write("<script lang='JavaScript'>alert('Araç Sayısı Giriniz !');</script>");
                }
                else
                {
                    if (RadioButtonList3.SelectedItem.Value == "Büyük Baş")
                    {
                        tablo = "ErzincanBuyukBas";
                        Ekle("Insert Into Sevkiyat (ErzincanBuyukBas,Arac,Tarih) values(@ErzincanBuyukBas,@Arac,@Tarih)", TextBox8.Text, TextBox7.Text);
                        Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                    }
                    else if (RadioButtonList3.SelectedItem.Value == "Küçük Baş")
                    {
                        tablo = "ErzincanKucukBas";
                        Ekle("Insert Into Sevkiyat (ErzincanKucukBas,Arac,Tarih) values(@ErzincanKucukBas,@Arac,@Tarih)", TextBox8.Text, TextBox7.Text);
                        Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                    }
                    else if (RadioButtonList3.SelectedItem.Value == "Kanatlı")
                    {
                        tablo = "ErzincanKanatli";
                        Ekle("Insert Into Sevkiyat (ErzincanKanatli,Arac,Tarih) values(@ErzincanKanatli,@Arac,@Tarih)", TextBox8.Text, TextBox7.Text);
                        Response.Write("<script lang='JavaScript'>alert('Başarı ile eklendi');</script>");
                    }
                    Label10.Text = "";
                    Sil();
                }
                
            }
            catch (Exception)
            {
                Label10.Text = "Tüm Alanlar Doldurulmalıdır!";
            }
           
        }
    }
}