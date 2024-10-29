using RMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace RMS_UI
{
    public partial class WaiterDashboardForm : Form
    {
        private List<OrderModel> orders = new List<OrderModel>();
        private AccountModel acc = new AccountModel();
        
        public WaiterDashboardForm(AccountModel acc)
        {
            InitializeComponent();
            this.acc = acc;
            waiterLabel.Text = acc.accountName;
            


            WireUpOrders();
        }

        public void WireUpOrders()
        {
            orders = GlobalConfig.Cnn.GetAllOrders(acc.accountID);
            currentOrdersListBox.DataSource = orders;
            currentOrdersListBox.DisplayMember = "orderDisplay";
            currentOrdersListBox.ClearSelected();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrder = new NewOrderForm(acc.accountID);
            newOrder.ShowDialog();
            WireUpOrders();
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            NewMenuItemForm newItemForm = new NewMenuItemForm();
            newItemForm.ShowDialog();
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            if (currentOrdersListBox.SelectedItem != null)
            {
                OrderModel p = (OrderModel)currentOrdersListBox.SelectedItem;
                orders = GlobalConfig.Cnn.DeleteOrder(acc.accountID, p.orderID);
                currentOrdersListBox.DataSource = null;
                currentOrdersListBox.DataSource = orders;
                currentOrdersListBox.DisplayMember = "orderDisplay";
                currentOrdersListBox.ClearSelected();
            }
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            if (currentOrdersListBox.SelectedItem != null)
            {
                OrderModel p = (OrderModel)currentOrdersListBox.SelectedItem;
                EditOrderForm editOrder = new EditOrderForm(acc.accountID, p.orderID, p.tableNum);
                editOrder.ShowDialog();
                currentOrdersListBox.DataSource = null;
                orders = GlobalConfig.Cnn.GetAllOrders(acc.accountID);
                currentOrdersListBox.DataSource = orders;
                currentOrdersListBox.DisplayMember = "orderDisplay";
                currentOrdersListBox.ClearSelected();
            }
        }

        private void waiterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
