using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;

namespace NetProject2WallMountainStar
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox_Password.TextMode = TextBoxMode.Password;
        }

        protected void Button_Login_Click(object sender, EventArgs e)
        {
            if (UserData.Authenticate(TextBox_Username.Text, TextBox_Password.Text))
            {
                Response.Redirect("WebForm1.aspx");
            }
        }
    }
}