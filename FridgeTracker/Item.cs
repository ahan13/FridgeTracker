using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FridgeTracker
{
    public enum ItemTypes
    {
        Meat,
        Seafood,
        Vegetable,
        Grain,
        Fruit,
        Other
    }
    public class Item
    {
        #region
        public int ItemNumber { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
		
		[Display(Name = "Date Added")]
		public  DateTime DateAdded { get; set; }
        public ItemTypes Type { get; set; }
        #endregion

        #region Constructors
		public Item(){
			DateAdded = DateTime.Now;
		}
        public Item(string name)
        {
            Name = name;
            Quantity = 1;
            DateAdded = DateTime.Now;
            Type = ItemTypes.Other;
        }

        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
            DateAdded = DateTime.Now;
            Type = ItemTypes.Other;
        }

        public Item(string name, DateTime dateAdded)
        {
            Name = name;
            Quantity = 1;
            DateAdded = DateTime.Now;
            Type = ItemTypes.Other;
        }
        #endregion
    }
}
