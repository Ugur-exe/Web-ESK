using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-U0HV2JK;Initial Catalog=ESK;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.ToLongDateString();
            baglanti.Open();    
            SqlCommand komut = new SqlCommand(" Select *From Kullanici Where Id=@Id ", baglanti);
            komut.Parameters.AddWithValue("@Id", Session["Kullanici"]);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Label1.Text = "("+oku["Ad"].ToString() + " " + oku["Soyad"].ToString()+")";
            }
            baglanti.Close();
            oku.Close();
            Session.Timeout = 20;
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Depo.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Hayvan.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Transfer.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sevkiyat.aspx");
        }
    }
}