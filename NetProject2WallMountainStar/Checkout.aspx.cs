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

			if (((List<string>)Session["CartList"]).Count > 0)
			{
                
                    ((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Clear();
					foreach (var productName in (List<string>)Session["CartList"])
					{
						((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Add(productName);
					}
                
			}
            else
            {
                ((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Clear();
                ((DropDownList)Master.FindControl("DropDownListShoppingCart")).Items.Add("Empty Cart");

            }


		   Order order = (Order)Session["Order"];
			
		}

		protected void Button_Submit_Click(object sender, EventArgs e)
		{

		}
	}
}