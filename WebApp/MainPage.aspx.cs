using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class MainPage : System.Web.UI.Page
    {
        static HttpCookie cookie2 = new HttpCookie("ItemsInfo");

        protected void Page_Load(object sender, EventArgs e)
        {
            DataClassesShopDataContext dbContex = new DataClassesShopDataContext();
            GridView1.DataSource = from p in dbContex.Items
                                   join r in dbContex.Stocks on p.Item_id equals r.Item_id
                                   where r.Quantity != 0
                                   select p;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cookie2.Values[GridView1.SelectedRow.Cells[1].Text] = GridView1.SelectedRow.Cells[2].Text;
            Response.Cookies.Add(cookie2);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddIndex.aspx");
        }
    }
}