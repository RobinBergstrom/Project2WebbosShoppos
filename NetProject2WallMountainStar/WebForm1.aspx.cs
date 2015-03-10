using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopData;

namespace NetProject2WallMountainStar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
		public List<OrderRow> cartList;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
		protected void Button_AddToCart_Click(object sender, EventArgs e)
		{
			cartList = new List<OrderRow>();
			cartList.Add(new OrderRow(1, 5));

			foreach (GridViewRow row in GridView1.Rows)
			{
				string apa = string.Format("artikelnummer:{0} namn:{1} pris:{2} antal:{3} \r\n", row.Cells[1].Text,
					row.Cells[2].Text, row.Cells[3].Text, TextBox_Quantity.Text);
				
				TextBox_CartList.Text += apa + "------------------------------\r\n";
			}
			
			//foreach (var item in cartList)
			//{
			//	TextBox1.Text += item.ArticleID + " " + item.Quantity + "\r\n";

			//}
		}
    }
}