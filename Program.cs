using System;
using System.Collections.Generic;
using System.Text;

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
            //TODO: add catch, catch N or other invalid selections
            int userSelection = int.Parse(Console.ReadLine());

            while (userChoosing)
            {
                bool valid = false;

                foreach (var item in itemMenuList)
                {
                    if (userSelection == int.Parse(item.ItemNumber))
                    {
                        //add to userOrder.txt
                        //https://stackoverflow.com/questions/15456845/getting-a-list-item-by-index
                        userOrder.Add(item);
                        for (int i = 0; i < userOrder.Count; i++)
                        {
                            StringBuilder userItem = new StringBuilder(i);
                        }

                        //    userorder.Add(new ItemProperties ...
                        //userOrder.CopyTo(userSelection, userOrder.ToArray(), userOrder.Count + 1, 2);

                        //        var finalList = ItemTextFile.ReadItems("../../../UserOrder.txt");
                        valid = true;

                        //TODO: Quantity?
                        Console.WriteLine("Anything else? # or N");
                        var input = Console.ReadLine().ToUpper();
                        if (input == "N")
                        {
                            userChoosing = false;
                            ItemTextFile.WriteItems();
                        }
                        else
                        {
                            userSelection = int.Parse(input);
                        }
                    }
                }

                if (!valid)
                {
                    Console.WriteLine("Please choose a correct selection");
                    userSelection = int.Parse(Console.ReadLine());
                }
            }
        }
        //
    }
}


