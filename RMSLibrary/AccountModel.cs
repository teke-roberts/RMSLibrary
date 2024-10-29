using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSLibrary
{
    public class AccountModel
    {
        public int accountID { get; set; }

        public string accountName { get; set; } = string.Empty;

        public string accountPassword { get; set; } = string.Empty;

        public string accountType { get; set; } = string.Empty;

        //public List<OrderModel> accountOrders { get; set; } = new List<OrderModel>();

        public AccountModel(int id, string name, string password, string type)
        { 
            accountID = id;
            accountName = name;
            accountPassword = password;
            accountType = type;
        }

        public AccountModel(string name, string password, string type)
        {
            accountName = name;
            accountPassword = password;
            accountType = type;
        }

        public AccountModel() { }
    }
}
