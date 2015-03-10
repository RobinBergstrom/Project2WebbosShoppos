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
	        public OrderRow(int articleID, int quantity)
	        {
		        ArticleID = articleID;
		        Quantity = quantity;
	        }
            public int ArticleID { get; set; }
            public int Quantity { get; set; }

        }
    
}
