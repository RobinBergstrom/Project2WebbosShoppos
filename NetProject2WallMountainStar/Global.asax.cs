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
	        Session["Order"] = new Order();
	        Session["Cart"] = new DropDownList();



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

        }

        protected void Session_End(object sender, EventArgs e)
        {
	        Session["Order"] = null;
	        Session["Cart"] = null;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}