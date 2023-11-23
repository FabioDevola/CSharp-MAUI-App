using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeSparesInventorySystem.Data.Models
{
    public class InventoryThing
    {
        public List<string> items;

        public InventoryThing()
        {
            items = new List<string>();
        }

        // Method to add an item to the inventory
        public void AddItem(string item)
        {
            items.Add(item);
        }

        // Method to delete an item from the inventory
        public bool DeleteItem(string item)
        {
            return items.Remove(item);
        }
    }
}