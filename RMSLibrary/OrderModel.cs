using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSLibrary
{
    public class OrderModel
    {
        public int orderID { get; set; }

        public decimal orderTotal { get; set; }

        public int waiter { get; set; }
        public List<ItemModel> items { get; set; } = new List<ItemModel>();

        public int tableNum { get; set; }

        public string orderDisplay
        {
            get
            {
                return "Order: " + orderID.ToString() + " / " + "Table: " + tableNum.ToString() + " / " + "Total: " + Math.Round(orderTotal, 2);
            }
        }

        public OrderModel(decimal total, int acc, List<ItemModel> orderItems, int table)
        {
            orderTotal = total;
            waiter = acc;
            items = orderItems;
            tableNum = table;
        }

        public OrderModel(int orderID, decimal total, int acc, List<ItemModel> orderItems, int table)
        {
            this.orderID = orderID;
            orderTotal = total;
            waiter = acc;
            items = orderItems;
            tableNum = table;
        }

        public OrderModel(int id, int TableNumber, int AccountId, decimal OrderTotal)
        {
            orderID = id;
            orderTotal = OrderTotal;
            waiter = AccountId;
            tableNum = TableNumber;
        }
    }
}
