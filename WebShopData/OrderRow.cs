using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace WebShopData
{
   
	
		public class OrderRow
		{
			public OrderRow(int articleid = 0, string name = "", int quantity = 0)
			{
				ArticleID = articleid;
				Name = name;
				Quantity = quantity;
			}
			public int ArticleID { get; set; }
			public string Name { get; set; }
			public int Quantity { get; set; }

			public override string ToString()
			{
				return string.Format("Product: {0}  Qty: {1}", Name, Quantity);
			}
		}
	
}
