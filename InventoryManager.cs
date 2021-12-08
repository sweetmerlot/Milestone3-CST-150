using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryItemsConsole
{
    class InventoryManager
    {
        private InventoryItemEntry[] items = new InventoryItemEntry[1024];
        private int productCount = 0;
        private int maxProduct = 1024;


        //Add a new item to the inventory manager.
        //checks to see if item already exists in the inventory
        public void AddItem(InventoryItem item)
        {
            for (int i = 0; i < productCount; i++)
            {
                InventoryItemEntry entry = items[i];
                if(entry.Item.Sku == item.Sku)
                {
                    Console.WriteLine("Item already exists");
                    return;
                }
            }

            if (productCount == maxProduct)
            {
                Console.Error.WriteLine("The inventory manager is full");
                return;
            }
            //if the item did not exist, we add it to the inventory at the next available index
            items[productCount] = new InventoryItemEntry(item);
            productCount += 1;
        }
        
        //Remove an item from the inventory manager.
        public void RemoveItem(String sku)
        {
            for (int i = 0; i < productCount; i++)
            {
                InventoryItemEntry entry = items[i];
                if(entry.Item.Sku == sku)
                {
                    //if item is last in the list, set the index = null and nothing further is needed
                    if (i == productCount)
                    {
                        items[i] = null;
                        return;
                    }
                    //otherwise move the last item into the index that will be removed, then remove the last item.
                    items[i] = items[productCount - 1];
                    items[productCount] = null;
                    productCount -= 1;
                }
            }
        }
        //Re-stock an item in the inventory manager.
        public void StockItem(String sku, int change) //enter the sku and the amount to change by
        {
            for (int i = 0; i < productCount; i++)
            {
                InventoryItemEntry entry = items[i]; //temp item storage looks for a sku match
                if (entry.Item.Sku == sku)  
                {
                    if (entry.Count + change >= 0)
                    {
                        entry.Count += change;
                    }
                }
            }
        }
        //Display the items in the inventory manager.
        public void DisplayItems()
        {
            for (int i = 0; i < productCount; i++)
            {
                InventoryItemEntry entry = items[i];
                Console.WriteLine(entry);
            }
        }
        

        //Search for an item in the inventory manager by at least two criteria(name, price, quantity, etc.)
        public InventoryItemEntry SearchItemBySku (String sku)
        {
            for (int i = 0; i < productCount; i++)
            {
                InventoryItemEntry entry = items[i];
                if(entry.Item.Sku == sku)
                {
                    return entry;
                }                
            }
            return null;
        }
        public InventoryItemEntry SearchItemByName (String name)
        {
            for (int i = 0; i < productCount; i++)
            {
                InventoryItemEntry entry = items[i];
                if(entry.Item.ItemName == name)
                {
                    return entry;
                }
            }
            return null;
        }
    }
}
