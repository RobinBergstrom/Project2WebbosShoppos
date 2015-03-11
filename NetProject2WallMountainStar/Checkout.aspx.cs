using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;

namespace NetProject2WallMountainStar
{
	public partial class Checkout : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
			var shoppingcart = Master.FindControl("DropDownListShoppingCart") as DropDownList;
            Order order = (Order)Session["Order"];
            //shoppingcart.Items.Add(order);
		}

		protected void Button_Submit_Click(object sender, EventArgs e)
		{

		}
	}
}