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
		

		protected void Page_Load(object sender, EventArgs e)
		{
			var name = User.Identity.Name;
            

		}
		protected void Button_AddToCart_Click(object sender, EventArgs e)
		{
			
			((List<string>)Session["CartList"]).Add(GridView1.SelectedRow.Cells[2].Text);

			((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Clear();
		   foreach (var productName in (List<string>)Session["CartList"])
			{
				((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Add(productName);
			}


		}

		protected void Button_Checkout_Click(object sender, EventArgs e)
		{
			Response.Redirect("Checkout.aspx");
		}

		protected void Button_SignOut_Click(object sender, EventArgs e)
		{

		}
	}
}