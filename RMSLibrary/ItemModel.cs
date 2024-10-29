using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSLibrary
{
    public class ItemModel
    {
        public int itemID { get; set; } 
        public decimal itemPrice { get; set; }

        public string itemName { get; set; } = string.Empty;

        public string itemDescription { get; set; } = string.Empty;

        public string itemCategory { get; set; } = string.Empty;

        public string itemDisplay
        {
            get
            {
                return itemName + " / " + Math.Round(itemPrice, 2);
            }
        }

        
        
        public ItemModel(string name, string price, string description, string category)
        {
            itemName = name;

            decimal priceItem;
            decimal.TryParse(price, out priceItem);
            itemPrice = priceItem;

            itemDescription = description;
            itemCategory = category;
        }

        public ItemModel(int id, string itemName, decimal itemPrice, string itemDescription, string itemCategory)
        {
            itemID = id;
            this.itemName = itemName;

            this.itemPrice = itemPrice;

            this.itemDescription = itemDescription;
            this.itemCategory = itemCategory;
        }
    }
}
