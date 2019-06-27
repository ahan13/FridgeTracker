using System;
using System.Collections.Generic;
using System.Text;

namespace FridgeTracker
{
    class Item
    {
        #region
        public string Name { get; set; }
        public int Quantity { get; set; }
        public  DateTime DateAdded { get; set; }
        public string Type { get; set; }
        #endregion
    }
}
