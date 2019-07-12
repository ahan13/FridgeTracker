using System;
using System.Collections.Generic;


namespace FridgeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge.Name = "My Fridge";

            while (true)
            {
                Console.WriteLine("Welcome to Fridge Tracker");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Show Fridge Details");
                Console.WriteLine("2. Show Items in Fridge");
                Console.WriteLine("3. Add Item to Fridge");
                Console.WriteLine("4. Clear Fridge");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Thanks for visiting the app.");
                        return;
                    case "1":
                        Fridge.showFridgeDetails();
                        break;
                    case "2":
                        List<Item> fridgeItems = Fridge.showFridgeItems();
                        if (fridgeItems.Count > 0)
                        {
                            foreach (Item item in fridgeItems)
                            {
                                Console.WriteLine($"Item Name:  \"{item.Name}\" Quantity: {item.Quantity}  Type: {item.Type} Date Added:  {item.DateAdded}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fridge is empty!");
                        }
                        
                        break;
                    case "3":
                        Console.WriteLine("Please enter item name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter quantity");
                        string quantityString = Console.ReadLine();
                        int quantity = Convert.ToInt32(quantityString);
                        if(Fridge.AddItemToFridge(new Item(name, quantity)))
                        {
                            Console.WriteLine($"{name} has been added!");
                        }

                        break;
                    case "4":
                        Fridge.clearFridge();
                        Console.WriteLine("Your Fridge has been cleared!");

                        break;
                    default: return;

                }
            }
            

        }

        
    }
}
