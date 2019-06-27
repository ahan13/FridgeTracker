using System;

namespace FridgeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFridge = new Fridge("My Fridge");

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
                        myFridge.showFridgeDetails();
                        break;
                    case "2":
                        myFridge.showFridgeItems();
                        break;
                    case "3":
                        Console.WriteLine("Please enter item name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter quantity");
                        string quantityString = Console.ReadLine();
                        int quantity = Convert.ToInt32(quantityString);
                        myFridge.AddItemToFridge(new Item(name, quantity));
                        break;
                    case "4":
                        break;
                    default: return;

                }
            }
            

        }

        
    }
}
