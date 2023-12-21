using System;
using System.Collections.Generic;

namespace Models
{
    public class Warehouse
    {
        private Dictionary<string, decimal> inventory;

        public Warehouse(Dictionary<string, decimal> inventory)
        {
            this.inventory = inventory;
        }

        public void updateInventory(string itemName,  decimal quantityChange)
        {
            this.inventory[itemName] += quantityChange;
        }

    }
}