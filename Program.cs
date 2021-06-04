using System;

namespace CashRegApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var app = new StoreApp();
            //StoreApp.UserItemMenu();

            var app = new ItemTextFile();

            var userItemList = ItemTextFile.ReadItemMenu();
            //var userReceipt = ItemTextFile.WriteItems();

            foreach (var item in userItemList)
            {
                Console.WriteLine($"{item.ItemNumber} | {item.Name} | {item.Price} | {item.Description}");
            }

            Console.WriteLine("\nWhat # would you like to order?");
            string userOrder = Console.ReadLine();

            foreach (var item in userItemList)
            {
                if (userOrder == item.ItemNumber)
                {
                    //add to userOrder

                }

            }

        }


        //ItemTextFile.WriteItems();

    }
}

