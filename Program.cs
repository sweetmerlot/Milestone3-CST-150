using System;

namespace InventoryItemsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the inventory manager
            InventoryManager im = new InventoryManager();

            //add some items
            im.AddItem(new InventoryItem("Item 1", "sku123", "Item 1's description", 13.49m, 1));
            im.AddItem(new InventoryItem("Item 2", "sku456", "Item 2's description", 24.49m, 3));
            im.AddItem(new InventoryItem("Item 3", "sku789", "Item 3's description", 34.49m, 5));
            im.AddItem(new InventoryItem("Item 4", "sku951", "Item 4's description", 46.49m, 2));
            im.AddItem(new InventoryItem("Item 5", "sku753", "Item 5's description", 53.49m, 1));

            //display the items
            Console.WriteLine("ALL ITEMS IN INVENTORY");
            im.DisplayItems();
            Console.WriteLine("****************************************************");

            //stock an item            
            im.StockItem("sku123", 50);
            im.StockItem("sku456", 32);
            Console.WriteLine("AFTER ITEM 1 AND 2 STOCK");
            im.DisplayItems();
            Console.WriteLine("****************************************************");

            //search item by name
            InventoryItemEntry foundItem = im.SearchItemByName("Item 1");
            Console.WriteLine("A SEARCH BY NAME OF ITEM 1");
            Console.WriteLine(foundItem + " was found");
            Console.WriteLine("****************************************************");

            //seach item by sku
            foundItem = im.SearchItemBySku("sku753");
            Console.WriteLine("A SEARCH BY SKU SKU753");
            Console.WriteLine(foundItem + " was found");
            Console.WriteLine("****************************************************");

            //remove an item
            im.RemoveItem("sku789");
            Console.WriteLine("ITEM 3 WAS REMOVED");
            im.DisplayItems();
        }
    }
}
