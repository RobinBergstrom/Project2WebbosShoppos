using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
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
		}
		protected void Button_AddToCart_Click(object sender, EventArgs e)
		{
			var order = (Order)Session["CurrentOrder"];

			AddOrderRow(order);

			AddToDropDownList(order);
		}

		private void AddToDropDownList(Order order)
		{
			ArticlesTableAdapter articlesTableAdapter = new ArticlesTableAdapter();

			var shoppingCart = ((DropDownList) Master.FindControl("DropDownListShoppingCart"));
			shoppingCart.Items.Clear();

			foreach (var item in order.OrderRows)
			{
				shoppingCart.Items.Add(articlesTableAdapter.GetProductNameQuery(item.ArticleID) + " " + item.ToString());
			}
		}

		private void AddOrderRow(Order order)
		{

			if (order == null)
				return;


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
			Server.Transfer("Checkout.aspx");
		}

		protected void Button_SignOut_Click(object sender, EventArgs e)
		{

		}
	}
}