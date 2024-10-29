using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Security.Cryptography.X509Certificates;

namespace RMSLibrary
{
    public class SqlConnection
    {
        public ItemModel AddMenuItem(ItemModel item)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@ItemName", item.itemName);
                p.Add("@ItemPrice", item.itemPrice);
                p.Add("@ItemDescription", item.itemDescription);
                p.Add("@ItemCategory", item.itemCategory);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spItems_Insert", p, commandType: CommandType.StoredProcedure);

                item.itemID = p.Get<int>("@id");
                return item;
            }
        }

        public List<ItemModel> GetAllItems()
        {
            List<ItemModel> output = new List<ItemModel>();
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                output = connection.Query<ItemModel>("dbo.spGetAllItems").ToList();
            }
            return output;
        }

        public List<ItemModel> GetCurrentOrderDetails(int orderId)
        {
            List<ItemModel> output = new List<ItemModel>();
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@OrderId", orderId);

                output = connection.Query<ItemModel>("dbo.spGetCurrentOrderDetails", p).ToList();
            }

            return output;
        }

        public void UpdateOrder(OrderModel order)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@OrderId", order.orderID);
                p.Add("@OrderTotal", order.orderTotal);
                p.Add("@TableNumber", order.tableNum);

                connection.Execute("dbo.spUpdateOrder", p, commandType: CommandType.StoredProcedure);

                foreach(ItemModel i in order.items)
                {
                    p = new DynamicParameters();
                    p.Add("@itemId", i.itemID);
                    p.Add("@orderId", order.orderID);

                    connection.Execute("dbo.spOrderDetail_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public OrderModel AddNewOrder(OrderModel order)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@OrderTotal", order.orderTotal);
                p.Add("@AccountId", order.waiter);
                p.Add("@TableNumber", order.tableNum);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spOrder_Insert", p, commandType: CommandType.StoredProcedure);
                order.orderID = p.Get<int>("@id");

                foreach(ItemModel i in order.items)
                {
                    p = new DynamicParameters();
                    p.Add("@itemId", i.itemID);
                    p.Add("@orderId", order.orderID);

                    connection.Execute("dbo.spOrderDetail_Insert", p, commandType: CommandType.StoredProcedure);
                }
                
                return order;
            }

            
        }

        public List<OrderModel> GetAllOrders(int waiterId)
        {
            List<OrderModel> output = new List<OrderModel>();
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@accountId", waiterId);

                output = connection.Query<OrderModel>("dbo.spGetAllOrders", p).ToList();
            }

            return output;
        }

        public List<OrderModel> DeleteOrder(int accountId, int orderId)
        {
            List<OrderModel> output = new List<OrderModel>();
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@OrderId", orderId);
                p.Add("@AccountId", accountId);

                output = connection.Query<OrderModel>("dbo.spDeleteOrder", p).ToList();
            }

            return output;
        }

        public void AddNewAccount(AccountModel acc)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@AccountUser", acc.accountName);
                p.Add("@AccountPass", acc.accountPassword);
                p.Add("@AccountType", acc.accountType);

                connection.Execute("dbo.spAccount_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public bool ValidUsername(string username)
        {
            string output;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@AccountUsername", username);
                p.Add("@name", 50, dbType: DbType.String, direction: ParameterDirection.Output);

                connection.Execute("dbo.ValidateUsername", p, commandType: CommandType.StoredProcedure);

                output = p.Get<string>("@name");
            }

            if(output == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public AccountModel GetAccount(string username)
        {
            AccountModel acc = new AccountModel();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("rmsDB")))
            {
                var p = new DynamicParameters();
                p.Add("@AccountUsername", username);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@pass", "", dbType: DbType.String, direction: ParameterDirection.Output);
                p.Add("@type", "", dbType: DbType.String, direction: ParameterDirection.Output);

                
                connection.Execute("dbo.spGetAccount", p, commandType: CommandType.StoredProcedure);

                acc.accountID = p.Get<int>("@id");
                acc.accountName = username;
                acc.accountPassword = p.Get<string>("@pass");
                acc.accountType = p.Get<string>("@type");
                
            }
            return acc;
        }
    }
}
