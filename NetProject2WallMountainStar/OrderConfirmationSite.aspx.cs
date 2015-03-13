using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;

namespace NetProject2WallMountainStar
{
	public partial class OrderConfirmationSite : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            Session["CurrentOrder"] = new Order("", "", "",1);
			string email = (string) Session["Email"];
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Server.Transfer("WebForm1.aspx");
		}
	}
}