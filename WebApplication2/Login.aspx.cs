using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WebApplication2
{       
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-U0HV2JK;Initial Catalog=ESK;Integrated Security=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text==""||TextBox2.Text=="")
            {
                
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From Kullanici Where Id=@Id and Sifre=@Sifre", baglanti);
            komut.Parameters.AddWithValue("@Id", TextBox1.Text);
            komut.Parameters.AddWithValue("@Sifre", TextBox2.Text);
            SqlDataReader oku= komut.ExecuteReader();
                if (oku.Read())
                {
                    Session["Kullanici"] = oku["Id"].ToString();
                    Response.Redirect("~/Depo.aspx");
                }
                else
                {
                    Label4.Text = "Kullanıcı adı veya şifre yanlış!";
                }
                oku.Close();
                baglanti.Close();
                baglanti.Dispose();
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}