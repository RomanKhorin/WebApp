using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Bag : System.Web.UI.Page
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();

        protected void Page_Init(object sender, EventArgs e)
        {
            Table_Load();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Table_Load()
        {
            HttpCookie cookie = Request.Cookies["ItemsInfo"];
            if (cookie != null)
            {
                if (cookie.HasKeys)
                {
                    for (int j = 0; j < cookie.Values.Count; j++)
                    {
                        dic.Add(Convert.ToString(Server.HtmlEncode(cookie.Values.AllKeys[j])), Server.HtmlEncode(cookie.Values[j]));
                    }
                    GridView1.DataSource = dic.Values;
                    GridView1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];

            if (cookie != null)
            {
                DataClassesShopDataContext dbContext = new DataClassesShopDataContext();
                int b = 0; //переменная для индекса заказа
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    //проверяем остатки данного товара на складе
                    var query = (from st in dbContext.Stocks
                                 where st.Item_id == int.Parse(dic.Keys.ElementAt(i))
                                 select st.Quantity).First();

                    var value = GridView1.Rows[i].Cells[0].Controls[1] as TextBox; //количество нужного товара
                    decimal quantity = Convert.ToDecimal(value.Text);
                    if ((query > quantity) && (GridView1.Rows[i].Cells[0].Text != null))
                    {
                        if (b == 0) //если мы отправлем заказ первый раз
                        {
                            //создаем заказ в таблице Order
                            Order ord = new Order { Order_dt = DateTime.Now, Username = cookie["Username"] };
                            dbContext.Orders.InsertOnSubmit(ord);
                            dbContext.SubmitChanges();

                            //считываем ID этого заказа
                            b = (from ord2 in dbContext.Orders
                                 where ord2.Username == cookie["Username"]
                                 orderby ord2.Order_dt descending
                                 select ord2.Order_Id).First();
                        }
                        //узнаем цену товара
                        var price = (from ce in dbContext.Items
                                     where ce.Item_id == int.Parse(dic.Keys.ElementAt(i))
                                     select ce.Price).Single();
                        //создаем заказ по позиции в таблице Order_details
                        Order_detail det = new Order_detail
                        {
                            Order_id = b,
                            Item_id = int.Parse(dic.Keys.ElementAt(i)),
                            Quantity = Convert.ToInt32(quantity),
                            Price = Convert.ToDecimal(price),
                            Amount = Convert.ToDecimal(price) * quantity
                        };
                        dbContext.Order_details.InsertOnSubmit(det);
                        //уменьшаем количество товара на складе
                        using (DataClassesShopDataContext dbContext2 = new DataClassesShopDataContext())
                        {
                            Stock stock = dbContext2.Stocks.SingleOrDefault(x => x.Item_id == int.Parse(dic.Keys.ElementAt(i)));
                            stock.Quantity = Convert.ToInt32(query) - Convert.ToInt32(quantity);
                            dbContext2.SubmitChanges();
                        }
                    }
                }
                dbContext.SubmitChanges();
                //удаляем куки
                if (Request.Cookies["ItemsInfo"] != null)
                {
                    var c = new HttpCookie("ItemsInfo");
                    c.Expires = DateTime.Now.AddDays(-1d);
                    Response.Cookies.Add(c);
                }
                dic.Clear(); //очищаем словарь
                Response.Redirect("Bag.aspx");
            }
            else
            {
                Response.Redirect("User.aspx");
            }
        }
    }
}