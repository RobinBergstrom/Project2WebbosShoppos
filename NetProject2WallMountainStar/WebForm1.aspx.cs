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
		private string name;

		protected void Page_Load(object sender, EventArgs e)
		{
			name = User.Identity.Name;


		}
		protected void Button_AddToCart_Click(object sender, EventArgs e)
		{

			// ((List<string>)Session["CartList"]).Add(GridView1.SelectedRow.Cells[2].Text);

			// ((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Clear();
			//foreach (var productName in (List<string>)Session["CartList"])
			// {
			//	 ((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Add(productName);
			// }

			//OrderRow orderRow = null;




			var order = (Order)Session["CurrentOrder"];

			int articleid = (int.Parse(GridView1.SelectedRow.Cells[1].Text));

			if (order.OrderRows.Count == 0)
			{
				order.OrderRows.Add(new OrderRow(int.Parse(GridView1.SelectedRow.Cells[1].Text),
					(GridView1.SelectedRow.Cells[2].Text), 1));
			}
			else
			{
				if (!LoopOrderRows(order, articleid))
				{
					order.OrderRows.Add(new OrderRow(int.Parse(GridView1.SelectedRow.Cells[1].Text),
					(GridView1.SelectedRow.Cells[2].Text), 1));
				}
			}
			//OrderRow orderRow = new OrderRow(int.Parse(GridView1.SelectedRow.Cells[1].Text), GridView1.SelectedRow.Cells[2].Text);

			((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Clear();
			foreach (var item in order.OrderRows)
			{
					((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Add(item.ToString());
			}
		}

		private static bool LoopOrderRows(Order order, int articleid)
		{
			bool flag = false;
			foreach (var row in order.OrderRows)
			{
				if (articleid == row.ArticleID)
				{
					row.Quantity += 1;
					flag = true;
				}
			
			}
			return flag;
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