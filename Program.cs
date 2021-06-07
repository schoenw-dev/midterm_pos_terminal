using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = new StringBuilder();
            bool ordering = true;
            while (ordering)
            {
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
                string userSelection = Console.ReadLine().ToUpper();

                Payment payment = null;

                while (userChoosing)
                {
                    bool valid = false;

                    foreach (var item in itemMenuList)
                    {
                        if (userSelection == item.ItemNumber)
                        {//TODO: ask for quantity
                            Console.WriteLine("\nHow many?");
                            int quantity = int.Parse(Console.ReadLine());
                            for (int i = 1; i <= quantity; i++)
                            {
                                userOrder.Add(item);
                            }

                            valid = true;
                        }
                    }

                    if (!valid && !(userSelection != "MENU" || userSelection != "M"))
                    {
                        Console.WriteLine("\nPlease make a valid # selection from the menu");
                    }

                    //TODO: Quantity?
                    Console.WriteLine("\nAnything else? Item #, Menu, or No");
                    var input = Console.ReadLine().ToUpper();
                    if (input == "N" || input == "NO")
                    {
                        userChoosing = false;
                        payment = ItemTextFile.WriteItems(userOrder);
                    }
                    else if (input == "MENU" || input == "M")
                    {
                        foreach (var items in itemMenuList)
                        {
                            Console.WriteLine($"{items.ItemNumber} | {items.Name} | {items.Price:C} | {items.Description}");
                        }
                        userChoosing = true;
                        userSelection = null;
                        valid = false;
                    }
                    else
                    {
                        userSelection = input;
                    }
                }

                var coutitemslist = userOrder.Distinct().ToList();

                foreach (var item in coutitemslist) //trying new solution for formatting
                {
                    userList.AppendLine($"{item.Name} | x{userOrder.Where(x => x.Name == item.Name).ToList().Count} | {item.Price}"); //TODO: quantity //make item quantity list?
                }

                userList.AppendLine($"Subtotal: {payment.Subtotal:C}")
                    .AppendLine($"Sales Tax: {payment.SalesTax:C}")
                    .AppendLine($"Grandtotal: {payment.Grandtotal:C}")
                    .AppendLine($"Payment method: {payment.PaymentMethod}");

                Console.WriteLine(userList.ToString());

                Console.WriteLine("New Order? Y or N");
                string newOrder = Console.ReadLine().ToUpper();
                if (newOrder == "Y")
                {
                    ordering = true;
                }
                else if (newOrder == "N")
                {
                    ordering = false;
                    Console.WriteLine("Thanks, BYE!");
                }
            }
        }
    }
}


