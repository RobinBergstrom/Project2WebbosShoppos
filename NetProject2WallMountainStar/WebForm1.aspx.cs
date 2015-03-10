using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;

namespace NetProject2WallMountainStar
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		public List<OrderRow> cartList;

		protected void Page_Load(object sender, EventArgs e)
		{
		
		}
		protected void Button_AddToCart_Click(object sender, EventArgs e)
		{
			
			//int id = int.Parse(GridView1.SelectedRow.Cells[1].Text);
			//string name = (GridView1.SelectedRow.Cells[2].Text);
			//double price = double.Parse(GridView1.SelectedRow.Cells[3].Text);
			
			//var shoppingcart = Master.FindControl("DropDownListShoppingCart") as DropDownList;
			//shoppingcart.Items.Add(GridView1.SelectedRow.Cells[2].Text);

			//cartList = new List<OrderRow>();
			//cartList.Add(new OrderRow(id));
			Order order = (Order)Session["Order"];
			Session["Cart"] = Master.FindControl("DropDownListShoppingCart") as DropDownList;
			
				
			
				
			//Session["Order"] = shoppingcart;



			//foreach (var item in cartList)
			//{
			//	TextBox1.Text += item.ArticleID + " " + item.Quantity + "\r\n";

			//}
		}

		protected void Button_Checkout_Click(object sender, EventArgs e)
		{
			Response.Redirect("Checkout.aspx");
		}
	}
}