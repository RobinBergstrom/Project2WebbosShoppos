using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;
using WebShopData.DataSet1TableAdapters;

namespace NetProject2WallMountainStar
{
	public partial class Checkout : System.Web.UI.Page
	{
		
		protected void Page_Load(object sender, EventArgs e)
		{
			ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

			var order = (Order)Session["CurrentOrder"];

			AddToDropDownList(order);

		}
		private void AddToDropDownList(Order order)
		{
			ArticlesTableAdapter articlesTableAdapter = new ArticlesTableAdapter();

			var shoppingCart = ((DropDownList)Master.FindControl("DropDownListShoppingCart"));
			shoppingCart.Items.Clear();

			foreach (var item in order.OrderRows)
			{
				shoppingCart.Items.Add(articlesTableAdapter.GetProductNameQuery(item.ArticleID) + " " + item.ToString());
			}
		}
		protected string GetProductNameByArticleId(int articleId)
		{
			var articleAdapter = new ArticlesTableAdapter();
		var result=	articleAdapter.GetProductNameQuery(articleId);
			return result;
		}

		protected decimal GetPriceByArticleId(int articleId)
		{
			var articleAdapter = new ArticlesTableAdapter();
			var result = decimal.Parse(articleAdapter.GetPriceByArticleIDQuery(articleId).ToString());
			return result;
		}

		protected void Button_SubmitOrder_Click(object sender, EventArgs e)
		{
			var order = (Order)Session["CurrentOrder"];
			UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
			
		
			order.Address = TextBox_Address.Text;
			order.City = TextBox_City.Text;
			order.Zip = TextBox_Zip.Text;
			order.UserID = (int)usersTableAdapter.GetUserIdByUsernameQuery(User.Identity.Name);
			Session["Email"] = TextBox_Email.Text;

			WebShopDAL webShopDal = new WebShopDAL();
			webShopDal.AddOrderToDB(order);
			Server.Transfer("OrderConfirmationSite.aspx");
		}

        protected void Button_Cancel_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm1.aspx");
        }
	}
}