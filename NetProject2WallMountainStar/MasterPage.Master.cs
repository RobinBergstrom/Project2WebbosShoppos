using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;

namespace NetProject2WallMountainStar
{
	public partial class MasterPage : System.Web.UI.MasterPage
	{
	   
		protected void Page_Load(object sender, EventArgs e)
		{
		  Label1.Text =  HttpContext.Current.User.Identity.Name;
		}

		protected void Button_SignOut_Click(object sender, EventArgs e)
		{
			FormsAuthentication.SignOut();
			Session["CurrentOrder"] = new Order("", "", "", 1);
			FormsAuthentication.RedirectToLoginPage();
		}

		protected void DropDownListShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}