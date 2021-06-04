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

            Console.WriteLine("\nWhat # would you like to order?");
            string userSelection = Console.ReadLine();

            while (userChoosing)
            {
                foreach (var item in itemMenuList)
                {
                    if (userSelection == item.ItemNumber)
                    {
                        //add to userOrder.txt
                        //https://stackoverflow.com/questions/15456845/getting-a-list-item-by-index

                        //    userorder.Add(new ItemProperties ...

                                ItemTextFile.WriteItems();
                        //        var finalList = ItemTextFile.ReadItems("../../../UserOrder.txt");
                    }
                    else
                    {
                        Console.WriteLine("Please select an item from our menu");
                    }
                }
                //Quantity?
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

