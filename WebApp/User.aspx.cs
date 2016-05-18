using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie = null;
        }

        private bool AuthenticateUser(string username, string password)
        {
            string CS = ConfigurationManager.ConnectionStrings["Shop_Khorin_Roman145_ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spAutentificateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramUsername = new SqlParameter("@Username", username);
                SqlParameter paramPassword = new SqlParameter("@Password", password);
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);
                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == 1;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (AuthenticateUser(TextBox1.Text, TextBox2.Text))
            {
                HttpCookie cookie = new HttpCookie("UserInfo");
                cookie["Username"] = TextBox1.Text;
                Response.Cookies.Add(cookie);
                Response.Redirect("MainPage.aspx");
            }
            else
            { Label2.Text = "Неправильные имя пользователя или пароль."; }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

    }
}