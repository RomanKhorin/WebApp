using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class AddIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text != null) && (TextBox2.Text != null))
            {
                DataClassesShopDataContext dbContext = new DataClassesShopDataContext();
                int useritem = Convert.ToInt32(TextBox1.Text);
                int userquantity = Convert.ToInt32(TextBox2.Text);
                //запрашиваем остатки данного товара на складе
                var query = (from st in dbContext.Stocks
                             where st.Item_id == useritem
                             select st.Quantity).First();

                Stock stock = dbContext.Stocks.SingleOrDefault(x => x.Item_id == useritem);
                stock.Quantity = Convert.ToInt32(query) + userquantity;
                dbContext.SubmitChanges();
                Response.Redirect("AddIndex.aspx");
            }

        }
    }
}