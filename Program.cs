using System;
using System.Collections.Generic;

namespace CashRegApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var app = new StoreApp();
            //StoreApp.UserItemMenu();
            List<ItemProperties> userOrder = new List<ItemProperties>();
            var itemMenuList = ItemTextFile.ReadItemMenu();
            bool userChoosing = true;
            //var userReceipt = ItemTextFile.WriteItems();

            foreach (var item in itemMenuList)
            {
                Console.WriteLine($"{item.ItemNumber} | {item.Name} | {item.Price:C} | {item.Description}");
            }

            //TODO: move elsewhere?
            Console.WriteLine("\nWhat # would you like to order?");
            int userSelection = int.Parse(Console.ReadLine());

            while (userChoosing)
            {
                foreach (var item in itemMenuList)
                {
                    if (userSelection == int.Parse(item.ItemNumber))
                    {
                        //add to userOrder.txt
                        //https://stackoverflow.com/questions/15456845/getting-a-list-item-by-index
                        userOrder.Add(new ItemProperties(item.ItemNumber, item.Name, item.Price, item.Description));
                        
                        //    userorder.Add(new ItemProperties ...
                        //userOrder.CopyTo(userSelection, userOrder.ToArray(), userOrder.Count + 1, 2);
                                ItemTextFile.WriteItems();
                        //        var finalList = ItemTextFile.ReadItems("../../../UserOrder.txt");
                    }
                    else if (userSelection != int.Parse(item.ItemNumber))
                    {
                        Console.WriteLine("Please select an item from our menu");
                    }
                }
                //TODO: Quantity?
                Console.WriteLine("Anything else? # or N");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    userChoosing = false;
                }
            }
        }


        //ItemTextFile.WriteItems();

    }
}

