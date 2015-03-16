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
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Server.Transfer("Webform1.aspx");
            }
        }

        protected void Button_BackToLogin_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session["CurrentOrder"] = new Order("", "", "", 1);
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}