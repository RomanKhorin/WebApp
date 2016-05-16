using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string CS = ConfigurationManager.ConnectionStrings["Shop_Khorin_Roman145_ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spRegisterUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Username = new SqlParameter("@Username", TextBox1.Text);
                    SqlParameter Password = new SqlParameter("@Password", TextBox2.Text);
                    SqlParameter Surname = new SqlParameter("@Surname", TextBox3.Text);
                    SqlParameter Name = new SqlParameter("@Name", TextBox4.Text);
                    SqlParameter Pathronymic = new SqlParameter("@Pathronymic", TextBox5.Text);
                    SqlParameter Customer_birth_dt = new SqlParameter("@Customer_birth_dt", TextBox6.Text);
                    SqlParameter Phone = new SqlParameter("@Phone", TextBox7.Text);
                    SqlParameter Address = new SqlParameter("@Address", TextBox8.Text);

                    cmd.Parameters.Add(Username);
                    cmd.Parameters.Add(Password);
                    cmd.Parameters.Add(Surname);
                    cmd.Parameters.Add(Name);
                    cmd.Parameters.Add(Pathronymic);
                    cmd.Parameters.Add(Customer_birth_dt);
                    cmd.Parameters.Add(Phone);
                    cmd.Parameters.Add(Address);

                    con.Open();
                    int ReturnCode = (int)cmd.ExecuteScalar();
                    if (ReturnCode == -1)
                    { Label2.Text = "Такой пользователь уже есть"; }
                    else
                    {
                        Response.Redirect("User.aspx");
                    }
                }
            }

        }
    }
}