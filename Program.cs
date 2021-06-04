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

            var app = new ItemTextFile();

            var userItemList = ItemTextFile.ReadItemMenu();
            //var userReceipt = ItemTextFile.WriteItems();

            foreach (var item in userItemList)
            {
                Console.WriteLine($"{item.ItemNumber} | {item.Name} | {item.Price:C} | {item.Description}");
            }

            Console.WriteLine("\nWhat # would you like to order?");
            string userSelection = Console.ReadLine();

            foreach (var item in userItemList)
            {
                if (userSelection == item.ItemNumber)
                {
                    //add to userOrder.txt
                    //https://stackoverflow.com/questions/15456845/getting-a-list-item-by-index

                    //    userorder.Add(new ItemProperties ...

                    //        ItemTextFile.WriteItems(userorder);
                    //        var finalList = ItemTextFile.ReadItems("../../../UserOrder.txt");
                }

            }

        }


        //ItemTextFile.WriteItems();

    }
}

