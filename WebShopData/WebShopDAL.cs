using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopData.DataSet1TableAdapters;

namespace WebShopData
{
   public class WebShopDAL
	{
		public void AddOrderToDB(Order order)
		{
			OrderHeadTableAdapter orderHeadTableAdapter = new OrderHeadTableAdapter();
			orderHeadTableAdapter.InsertOrderToDBQuery(order.UserID, order.Address, order.Zip, order.City, false);
			var orderID = (int)orderHeadTableAdapter.GetLastOrderIDQuery();
			OrderRowTableAdapter orderRowTableAdapter = new OrderRowTableAdapter();
			foreach (var row in order.OrderRows)
			{
				orderRowTableAdapter.InsertOrderRowQuery(orderID, row.Quantity, row.ArticleID);
			}
		}
	}
}
