using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeTracker
{
    static class Fridge
    {
        #region Properties
        public static string Name { get; set; }
        public static List<Item> ItemsList { get; set; }
        #endregion

        #region Methods
        public static void AddItemToFridge(Item item)
        {
            ItemsList.Add(item);
        }

        public static void RemoveItemFromFridge(Item item)
        {
            ItemsList.Remove(item);
        }

        public static void clearFridge()
        {
            ItemsList.Clear();
        }

        public static void showFridgeDetails()
        {
            Console.WriteLine($"Fridge Name: \"{Name}\" Number of Items In Fridge: {ItemsList.Count}");
        }

        public static void showFridgeItems()
        {
            foreach (Item item in ItemsList)
            {
                System.Console.WriteLine($"Item Name:  \"{item.Name}\" Quantity: {item.Quantity}  Type: {item.Type} Date Added:  {item.DateAdded}");
            }
        }
        #endregion

       
    }
}
