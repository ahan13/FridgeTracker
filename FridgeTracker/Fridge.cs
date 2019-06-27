using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeTracker
{
    class Fridge
    {
        #region Properties
        public string Name { get; set; }
        public List<Item> ItemsList { get; set; }
        #endregion

        #region Methods
        public void AddItemToFridge(Item item)
        {
            ItemsList.Add(item);
        }

        public void RemoveItemFromFridge(Item item)
        {
            ItemsList.Remove(item);
        }

        public void clearFridge()
        {
            ItemsList.Clear();
        }

        public void showFridgeDetails()
        {
            Console.WriteLine($"Fridge Name: \"{Name}\" Number of Items In Fridge: {ItemsList.Count}");
        }

        public void showFridgeItems()
        {
            foreach (Item item in ItemsList)
            {
                System.Console.WriteLine($"Item Name:  \"{item.Name}\" Quantity: {item.Quantity}  Type: {item.Type} Date Added:  {item.DateAdded}");
            }
        }
        #endregion

        #region Constructor
        public Fridge(string name)
        {
            Name = name;
            ItemsList = new List<Item>();
        }
        #endregion
    }
}
