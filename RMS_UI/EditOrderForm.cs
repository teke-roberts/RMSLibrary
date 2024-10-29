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

namespace RMS_UI
{
    public partial class EditOrderForm : Form
    {
        private List<ItemModel> menuItemsList = new List<ItemModel>();
        private List<ItemModel> currentOrderItemsList = new List<ItemModel>();

        private List<ItemModel> entrees = new List<ItemModel>();
        private List<ItemModel> apps = new List<ItemModel>();
        private List<ItemModel> drinks = new List<ItemModel>();
        private List<ItemModel> desserts = new List<ItemModel>();

        private AccountModel tempAcc = new AccountModel(1, "teke", "jade", "admin");
        private decimal oTax = 0;
        private decimal sTotal = 0;
        private decimal oTotal = 0;

        private int orderId
        {
            get; set;
        }

        private int id
        {
            get; set;
        }

        public EditOrderForm(int id, int orderId, int table)
        {
            InitializeComponent();
            this.id = id;
            currentOrderLabel.Text = orderId.ToString();
            this.orderId = orderId;
            tableNumberBox.SelectedItem = table.ToString();
            WireUpBox();

        }

        public void SepMenuItems()
        {
            foreach (ItemModel item in menuItemsList)
            {
                if(item.itemCategory == "Entree")
                {
                    entrees.Add(item);
                }
                else if(item.itemCategory == "Appetizer")
                {
                    apps.Add(item);
                }
                else if(item.itemCategory == "Drink")
                {
                    drinks.Add(item);
                }
                else
                {
                    desserts.Add(item);
                }
            }
        }

        public void WireUpBox()
        {
            menuItemsListBox.SelectedIndexChanged -= menuItemsListBox_SelectedIndexChanged;

            menuItemsList = GlobalConfig.Cnn.GetAllItems();
            SepMenuItems();
            menuItemsListBox.DataSource = entrees;
            menuItemsListBox.DisplayMember = "itemDisplay";
            entreesButton.BackColor = SystemColors.ActiveCaption;



            menuItemsListBox.ClearSelected();


            currentOrderItemsList.Clear();

            currentOrderItemsList = GlobalConfig.Cnn.GetCurrentOrderDetails(orderId);
            OrderTotal();
            
            currentOrderListBox.DataSource = currentOrderItemsList;
            currentOrderListBox.DisplayMember = "itemDisplay";


            menuItemsListBox.SelectedIndexChanged += menuItemsListBox_SelectedIndexChanged;
        }

        public void WireUpCurrentOrder()
        {
            currentOrderListBox.DataSource = null;
            currentOrderListBox.DataSource = currentOrderItemsList;
            currentOrderListBox.DisplayMember = "itemDisplay";
            OrderTotal();
        }

        public void OrderTotal()
        {
            sTotal = 0;
            foreach (ItemModel item in currentOrderItemsList)
            {
                sTotal += item.itemPrice;
            }
            sTotal = Math.Round(sTotal, 2);
            oTax = Math.Round(sTotal * (decimal).085, 2);
            oTotal = Math.Round(oTax + sTotal, 2);
            subTotalValue.Text = sTotal.ToString();
            taxValue.Text = oTax.ToString();
            totalValue.Text = oTotal.ToString();

        }

        
        private void enterOrderButton_Click(object sender, EventArgs e)
        {
            bool tableparse = int.TryParse(tableNumberBox.Text, out int tablenum);
            if(tableparse)
            {
                OrderModel order = new OrderModel(orderId, oTotal, id, currentOrderItemsList, tablenum);
                GlobalConfig.Cnn.UpdateOrder(order);

                this.Close();
            }
            
        }

        private void menuItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuItemsListBox.SelectedItem != null)
            {
                ItemModel p = (ItemModel)menuItemsListBox.SelectedItem;
                currentOrderItemsList.Add(p);
                WireUpCurrentOrder();
            }

        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void appetizersButton_Click(object sender, EventArgs e)
        {
            menuItemsListBox.SelectedIndexChanged -= menuItemsListBox_SelectedIndexChanged;

            menuItemsListBox.DataSource = apps;
            menuItemsListBox.DisplayMember = "itemDisplay";
            appetizersButton.BackColor = SystemColors.ActiveCaption;
            drinksButton.BackColor = SystemColors.ControlLight;
            dessertsButton.BackColor = SystemColors.ControlLight;
            entreesButton.BackColor = SystemColors.ControlLight;

            menuItemsListBox.ClearSelected();

            menuItemsListBox.SelectedIndexChanged += menuItemsListBox_SelectedIndexChanged;
        }

        private void entreesButton_Click(object sender, EventArgs e)
        {
            menuItemsListBox.SelectedIndexChanged -= menuItemsListBox_SelectedIndexChanged;

            menuItemsListBox.DataSource = entrees;
            menuItemsListBox.DisplayMember = "itemDisplay";
            entreesButton.BackColor = SystemColors.ActiveCaption;
            drinksButton.BackColor = SystemColors.ControlLight;
            dessertsButton.BackColor = SystemColors.ControlLight;
            appetizersButton.BackColor = SystemColors.ControlLight;

            menuItemsListBox.ClearSelected();

            menuItemsListBox.SelectedIndexChanged += menuItemsListBox_SelectedIndexChanged;
        }

        private void drinksButton_Click(object sender, EventArgs e)
        {
            menuItemsListBox.SelectedIndexChanged -= menuItemsListBox_SelectedIndexChanged;

            menuItemsListBox.DataSource = drinks;
            menuItemsListBox.DisplayMember = "itemDisplay";
            drinksButton.BackColor = SystemColors.ActiveCaption;
            entreesButton.BackColor = SystemColors.ControlLight;
            dessertsButton.BackColor = SystemColors.ControlLight;
            appetizersButton.BackColor = SystemColors.ControlLight;

            menuItemsListBox.ClearSelected();

            menuItemsListBox.SelectedIndexChanged += menuItemsListBox_SelectedIndexChanged;
        }

        private void dessertsButton_Click(object sender, EventArgs e)
        {
            menuItemsListBox.SelectedIndexChanged -= menuItemsListBox_SelectedIndexChanged;

            menuItemsListBox.DataSource = desserts;
            menuItemsListBox.DisplayMember = "itemDisplay";
            dessertsButton.BackColor = SystemColors.ActiveCaption;
            drinksButton.BackColor = SystemColors.ControlLight;
            entreesButton.BackColor = SystemColors.ControlLight;
            appetizersButton.BackColor = SystemColors.ControlLight;

            menuItemsListBox.ClearSelected();

            menuItemsListBox.SelectedIndexChanged += menuItemsListBox_SelectedIndexChanged;
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if(currentOrderListBox.SelectedItem != null)
            {
                ItemModel p = (ItemModel)currentOrderListBox.SelectedItem;
                currentOrderItemsList.Remove(p);
                WireUpCurrentOrder();
            }
        }

        
    }
}
