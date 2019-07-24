using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FridgeTracker
{
    static class Fridge
    {
        #region Properties
        public static FridgeContext db = new FridgeContext();
        public static string Name { get; set; }
        
        #endregion

        #region Methods
        public static bool AddItemToFridge(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return true;
        }

        public static bool RemoveItemFromFridge(Item item)
        {
            db.Items.Remove(item);
            db.SaveChanges();
            return true;

        }

        public static bool clearFridge()
        {
            foreach (Item item in db.Items){
                db.Items.Remove(item);
            }
            
            db.SaveChanges();
            return true;

        }

        public static string showFridgeDetails()
        {
            var count = db.Items.Count().ToString();
         
            return $"Fridge Name: \"{Name}\" Number of Items In Fridge: {count}";
        }

        public static IQueryable<Item> showFridgeItems()
        {
            return db.Set<Item>();
            
        }
        #endregion

        
    }
}
