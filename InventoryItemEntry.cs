using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryItemsConsole
{
    class InventoryItemEntry //the purpose of this class is to act as a counter for the inventory item
    {
        private InventoryItem item;
        private int count;

        public InventoryItemEntry(InventoryItem item)
        {
            this.item = item;
            this.count = 0;
        }
        public override string ToString()
        {
            return item.ToString() + " : " + count;
        }

        public InventoryItem Item { get => item; set => item = value; }
        public int Count { get => count; set => count = value; }
    }
}
