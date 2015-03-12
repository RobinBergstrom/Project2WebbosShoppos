using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using WebShopData;

namespace NetProject2WallMountainStar
{
	public class Global : System.Web.HttpApplication
	{
		//public List<OrderRow> sessionstartcartlist;
		protected void Application_Start(object sender, EventArgs e)
		{

		}

		protected void Session_Start(object sender, EventArgs e)
		{
			//Session["CartList"] = new List<string>();
			//Session["CurrentOrder"] = new Order("Olle","Ollesson","Ollegatan 12","Olletown","22222","jaja@gmail.com");
		    Session["CurrentOrder"] = new Order("", "", "", 1);
		    //var shoppingcart = Master.FindControl("DropDownListShoppingCart") as DropDownList;
		    //sessionstartcartlist = new List<OrderRow>();
			
		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{
			//Response.Redirect("ErrorPage.aspx");
		}

		protected void Session_End(object sender, EventArgs e)
		{
			Session["CurrentOrder"] = null;
		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}