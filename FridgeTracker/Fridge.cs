using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeTracker
{
    static class Fridge
    {
        #region Properties
        public static string Name { get; set; }
        public static List<Item> ItemsList = new List<Item>();
        
        #endregion

        #region Methods
        public static void AddItemToFridge(Item item)
        {
            ItemsList.Add(item);
            Console.WriteLine($"{item.Name} has been added!");
        }

        public static void RemoveItemFromFridge(Item item)
        {
            
            ItemsList.Remove(item);
            Console.WriteLine($"{item.Name} has been removed!");

        }

        public static void clearFridge()
        {
            ItemsList.Clear();
            Console.WriteLine("Your Fridge has been cleared!");

        }

        public static void showFridgeDetails()
        {
            Console.WriteLine($"Fridge Name: \"{Name}\" Number of Items In Fridge: {ItemsList.Count}");
        }

        public static void showFridgeItems()
        {
            if(ItemsList.Count != 0)
            {
                foreach (Item item in ItemsList)
                {
                    System.Console.WriteLine($"Item Name:  \"{item.Name}\" Quantity: {item.Quantity}  Type: {item.Type} Date Added:  {item.DateAdded}");
                }
            }
            else
            {
                Console.WriteLine("Your Fridge is empty!");
            }
            
        }
        #endregion

        
    }
}
