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
    public partial class NewMenuItemForm : Form
    {
        public NewMenuItemForm()
        {
            InitializeComponent();
        }



        public void AddItemButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                ItemModel item = new ItemModel(ItemNameBox.Text, ItemPriceBox.Text, ItemDescriptionBox.Text, ItemCategoryBox.Text);
                GlobalConfig.Cnn.AddMenuItem(item);
                ItemNameBox.Text = "";
                ItemPriceBox.Text = "0.00";
                ItemDescriptionBox.Text = "";
                ItemCategoryBox.Text = "";
            }
            
        }

        public bool ValidateForm()
        {
            bool output = true;
            string itemName = ItemNameBox.Text;

            //validating item name 
            foreach (char c in itemName)
            {
                if (!(Char.IsLetter(c) || Char.IsWhiteSpace(c) || Char.IsPunctuation(c) || Char.IsNumber(c)))
                {
                    output = false;
                }
            }

            if (itemName.Length < 1 || itemName.Length > 50)
            {
                output = false;
            }

            //validate item price
            decimal itemPrice;
            bool validPrice = Decimal.TryParse(ItemPriceBox.Text, out itemPrice);
            if (!validPrice || itemPrice <= 0)
            {
                output = false;
            }

            //validate item description
            string itemDescription = ItemDescriptionBox.Text;
            foreach (char c in itemDescription)
            {
                if (!(Char.IsLetter(c) || Char.IsWhiteSpace(c) || Char.IsPunctuation(c) || Char.IsNumber(c)))
                {
                    output = false;
                }
            }

            if (itemDescription.Length < 0 || itemDescription.Length > 500)
            {
                output = false;
            }

            return output;
        }

        private void NewMenuItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
