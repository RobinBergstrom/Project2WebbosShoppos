using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopData
{
    
    
        public class Order
        {
            public List<OrderRow> OrderRows { get; set; }
            public string Adress { get; set; }
            public string City { get; set; }
            public string Zip { get; set; }
            public int UserID { get; set; }

        }
    
}
