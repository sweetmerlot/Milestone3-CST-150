using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryItemsConsole
{
    class InventoryItem
    {
        private string itemName;
        private string sku;
        private string description;
        private decimal price;
        private int category;

        //item constructor
        public InventoryItem(string itemName, string sku, string description, decimal price, int category)
        {
            this.itemName = itemName;
            this.sku = sku;
            this.description = description;
            this.price = price;
            this.category = category;
        }
        //getters and setters
        public string ItemName { get => itemName; set => itemName = value; }
        public string Sku { get => sku; set => sku = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public int Category { get => category; set => category = value; }

        public override string ToString()
        {
            return sku + " : " + itemName + " : " + description + " : $" + price;
        }
        
    }
}
