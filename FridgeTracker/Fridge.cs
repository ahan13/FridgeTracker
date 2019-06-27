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
        public void AddItem(Item item)
        {
            ItemsList.Add(item);
        }

        public void RemoveItem(Item item)
        {
            ItemsList.Remove(item);
        }

        #endregion
    }
}
