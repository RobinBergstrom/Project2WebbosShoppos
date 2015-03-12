using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopData
{
        public class Order
        {
            public Order( string address, string city, string zip, int userid)
            {
	            OrderRows = new List<OrderRow>();
	            Address = address;
	            City = city;
	            Zip = zip;
	            UserID = userid;
            }
            public List<OrderRow> OrderRows { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Zip { get; set; }
            public int UserID { get; set; }        
        }
}
