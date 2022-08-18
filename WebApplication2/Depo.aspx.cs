using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-U0HV2JK;Initial Catalog=ESK;Integrated Security=True");
        int sonucbuyuk, buyukbas, sonuckucuk, kucukbas, kucuk, buyuk, kanat, sonuckanat, kanatli, toplamhayvan = 0, toplamfiyat = 0, arac = 0,
            buyuktransfer=0,kucuktransfer=0,kanatlitransfer=0;

        

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"]==null)
            {
                Response.Redirect("~/Login.aspx");
            }
            thayvan("Select Sum(Adet) From AnkaraBuyuk"); thayvan("Select Sum(Adet) From AnkaraKucuk"); thayvan("Select Sum(Adet) From AnkaraKanatli");
            thayvan("Select Sum(Adet) From ErzincanBuyuk");thayvan("Select Sum(Adet) From ErzincanKucuk"); thayvan("Select Sum(Adet) From ErzincanKanatli");
            Fiyat("Select Sum(Fiyat) From AnkaraBuyuk"); Fiyat("Select Sum(Fiyat) From AnkaraKucuk"); Fiyat("Select Sum(Fiyat) From AnkaraKanatli");
            Fiyat("Select Sum(Fiyat) From ErzincanBuyuk"); Fiyat("Select Sum(Fiyat) From ErzincanKucuk"); Fiyat("Select Sum(Fiyat) From ErzincanKanatli");
            Buyukbas("Select Sum(Adet) From AnkaraBuyuk"); Buyukbas("Select Sum(Adet) From ErzincanBuyuk");Arac("Select Sum(Arac) From Sevkiyat");
            Kucukbas("Select Sum(Adet) From AnkaraKucuk"); Kucukbas("Select Sum(Adet) From ErzincanKucuk");
            BuyukTransfer("Select Sum(BuyukBas) From Transfer"); Kanatli("Select Sum(Adet) From AnkaraKanatli"); Kanatli("Select Sum(Adet) From ErzincanKanatli");
            KucukTransfer("Select Sum(KucukBas) From Transfer"); KanatliTransfer("Select Sum(Kanatli) From Transfer");
            sonucbuyuk = (buyukbas * 100) / toplamhayvan; sonuckucuk = (kucukbas * 100) / toplamhayvan; sonuckanat = (kanatli * 100)/toplamhayvan;
            Label12.Text = toplamhayvan.ToString();Label13.Text = toplamfiyat.ToString()+" "+"Tl";Label17.Text=arac.ToString();
            Label14.Text = buyuktransfer.ToString();Label15.Text = kucuktransfer.ToString();Label16.Text = kanatlitransfer.ToString();
        }

        void thayvan(string a)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(a, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                toplamhayvan += Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void Fiyat(string a)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(a, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                toplamfiyat += Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void Buyukbas(string b)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(b, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                buyukbas += Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void Kucukbas(string c)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(c, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kucukbas += Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void Kanatli(string d)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(d, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kanatli += Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void Arac(string a)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(a, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                arac+= Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void BuyukTransfer(string a)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(a, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                buyuktransfer+= Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void KucukTransfer(string a)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(a, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kucuktransfer += Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }
        void KanatliTransfer(string a)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(a, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kanatlitransfer += Convert.ToInt32(oku[0]);
            }
            baglanti.Close();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            kucuk = Convert.ToInt32(Label2.Text);
            kucuk += 1;
            Literal2.Text = "<div style=\"background-color:red; height:28px; width:" + kucuk + "%;\"></div>";

            Label2.Text = kucuk.ToString();

            if (kucuk == sonuckucuk)
            {
                Timer1.Enabled = false;
            }
        }
        protected void Timer2_Tick(object sender, EventArgs e)
        {
            buyuk = Convert.ToInt32(Label1.Text);
            buyuk += 1;
            Literal1.Text = "<div style=\"background-color:blue; height:28px; width:" + buyuk + "%;\"></div>";
            Label1.Text = buyuk.ToString();
            if (buyuk == sonucbuyuk)
            {
                Timer2.Enabled = false;
            }
        }
        protected void Timer3_Tick1(object sender, EventArgs e)
        {
            kanat = Convert.ToInt32(Label5.Text);
            kanat += 1;
            Literal3.Text = "<div style=\"background-color:green; height:28px; width:" + kanat + "%;\"></div>";

            Label5.Text = kanat.ToString();

            if (kanat == sonuckanat)
            {
                Timer3.Enabled = false;
            }
        }
    }
    
        
    
}