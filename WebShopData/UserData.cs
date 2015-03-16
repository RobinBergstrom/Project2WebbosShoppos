using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using WebShopData.DataSet1TableAdapters;

namespace WebShopData
{
    
    
        public static class UserData
        {

            public static bool Authenticate(string userName, string password)
            {
                
                

                    UsersTableAdapter usersTable = new UsersTableAdapter();
                    var user = usersTable.GetData(userName, password);

                    if (user.Count > 0)
                    {
                        int id = user[0].UserID;
                        return true;

                    }
                    return false;

                
               
            }
        }
    }

