using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;
using WebShopData.DataSet1TableAdapters;

namespace NetProject2WallMountainStar
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		    Label_EmptyCart.Visible = false;
			var order = (Order)Session["CurrentOrder"];
			AddToDropDownList(order);
            var button_clear = ((Button)Master.FindControl("Button_ClearCartMaster"));
		    button_clear.Visible = true;
		}
		protected void Button_AddToCart_Click(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				var order = (Order)Session["CurrentOrder"];

				AddOrderRow(order);

				AddToDropDownList(order);
			}
		}
		private void AddToDropDownList(Order order)
		{
			int quantity = (int) Session["quantity"];
			ArticlesTableAdapter articlesTableAdapter = new ArticlesTableAdapter();

			var shoppingCart = ((DropDownList) Master.FindControl("DropDownListShoppingCart"));
			shoppingCart.Items.Clear();
			shoppingCart.Items.Add(string.Format("Cart ({0})", quantity));
			foreach (var item in order.OrderRows)
			{
				shoppingCart.Items.Add(articlesTableAdapter.GetProductNameQuery(item.ArticleID) + " " + item.ToString());
				
			}
		}
		private void AddOrderRow(Order order)
		{
			if (order == null || GridView1.SelectedRow == null)
				return;
			int quantity = (int)Session["quantity"];
		
			quantity++;
			Session["quantity"] = quantity;
			bool hasAdded = false;
			int articleid = (int.Parse(GridView1.SelectedRow.Cells[1].Text));
			order.OrderRows.ForEach(x =>
			{
				if (x.ArticleID == articleid)
				{
					x.Quantity++;
					hasAdded = true;
				}
			});
			if (!hasAdded)
			{
				order.OrderRows.Add(new OrderRow(int.Parse(GridView1.SelectedRow.Cells[1].Text), 1));
			}
		}
		protected void Button_Checkout_Click(object sender, EventArgs e)
		{
			var order = (Order) Session["CurrentOrder"];
			if (order.OrderRows.Count > 0)
			{
				Server.Transfer("Checkout.aspx");
			}
			else
			{
			    Label_EmptyCart.Visible = true;
			}
		}

		

		protected void Gridviewbutton_Buy(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				var order = (Order)Session["CurrentOrder"];

				AddOrderRow(order);

				AddToDropDownList(order);
			}
		}
	}
}