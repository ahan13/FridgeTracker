using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeTracker
{
    static class Fridge
    {
        #region Properties
        public static FridgeContext db = new FridgeContext();
        public static string Name { get; set; }
        public static List<Item> ItemsList = new List<Item>();
        
        #endregion

        #region Methods
        public static bool AddItemToFridge(Item item)
        {
            ItemsList.Add(item);
            db.Items.Add(item);
            db.SaveChanges();
            return true;
        }

        public static bool RemoveItemFromFridge(Item item)
        {
            ItemsList.Remove(item);
            db.Items.Remove(item);
            db.SaveChanges();
            return true;

        }

        public static bool clearFridge()
        {
            foreach (Item item in ItemsList){
                db.Items.Remove(item);
            }
            ItemsList.Clear();
            db.SaveChanges();
            return true;

        }

        public static string showFridgeDetails()
        {
            return $"Fridge Name: \"{Name}\" Number of Items In Fridge: {ItemsList.Count}";
        }

        public static List<Item> showFridgeItems()
        {
            return ItemsList;
            
        }
        #endregion

        
    }
}
