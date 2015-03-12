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

			var order = (Order)Session["CurrentOrder"];

			DropDownList masterDropDownList = ((DropDownList) Master.FindControl("DropDownListShoppingCart"));

			if (order.OrderRows.Count > 0)
			{
				masterDropDownList.Items.Clear();
				foreach (var item in order.OrderRows)
				{
					masterDropDownList.Items.Add(item.ToString());
				}
			}
            else
            {
                masterDropDownList.Items.Clear();
                masterDropDownList.Items.Add("Empty Cart");
            }
		}

		protected void Button_Submit_Click(object sender, EventArgs e)
		{

		}
	}
}