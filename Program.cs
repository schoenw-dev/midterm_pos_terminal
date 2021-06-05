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

            Payment payment = null;

            while (userChoosing)
            {
                bool valid = false;

                foreach (var item in itemMenuList)
                {
                    if (userSelection == int.Parse(item.ItemNumber))
                    {
                        userOrder.Add(item);

                        valid = true;

                        //TODO: Quantity?
                        Console.WriteLine("Anything else? # or N");
                        var input = Console.ReadLine().ToUpper();
                        if (input == "N")
                        {
                            userChoosing = false;
                            payment = ItemTextFile.WriteItems(userOrder);
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

            var userList = new StringBuilder();

            foreach (var item in userOrder)
            {
                userList.AppendLine($"{item.Name} | {item.Price}");
            }

            userList.AppendLine($"Subtotal: {payment.Subtotal:C}")
                .AppendLine($"Sales Tax: {payment.SalesTax:C}")
                .AppendLine($"Grandtotal: {payment.Grandtotal:C}")
                .AppendLine($"Payment method: {payment.PaymentMethod}");

            Console.WriteLine(userList.ToString());
        }
    }
}


