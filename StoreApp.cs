using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CashRegApp
{
    public class StoreApp
    {
        public static void UserItemMenu()
        {
            List<ItemProperties> userorder = new List<ItemProperties>();
            double total = 0;
            double final_total;
            double change;

            while (true)
            {
                var localMenu = ItemTextFile.ReadItems("../../../ItemMenu");

                Console.WriteLine("Please place your order");

                foreach (ItemProperties items in localMenu) // replace with providing txt file
                {
                    Console.WriteLine($"{items.Name},{items.Price},{items.Description}");
                }

                var userchoice = Console.ReadLine().ToLower();

                switch (userchoice)
                {
                    case "1":
                        //orders item in location 1
                        //will be expanded to give user custom options
                        userorder.Add(new ItemProperties { Name = "Hamburger", Price = 2.99, Description = "Test Hamburger" });

                        break;

                    case "2":
                        //orders item in location 2
                        userorder.Add(new ItemProperties { Name = "Hot Dog", Price = 1.99, Description = "Test Hot Dog" });

                        break;

                    case "3":
                        //orders item in location 3
                        userorder.Add(new ItemProperties { Name = "Nachos", Price = 1.99, Description = "Test Nachos" });

                        break;

                    default:
                        Console.WriteLine("Please select an item from our menu");
                        continue;
                }

                Console.WriteLine("Will that be all? Y/N");
                string userdone = Console.ReadLine().ToLower();

                if (userdone != "n")
                {
                    ItemTextFile.WriteItems(userorder);
                    var finalList = ItemTextFile.ReadItems("../../../UserOrder.txt"); //could use this to create a record of user purchases
                    Console.WriteLine("YOUR FINAL ORDER IS");

                    foreach (ItemProperties item1 in userorder)
                    {
                        Console.WriteLine($"{item1.Name},{item1.Price},{item1.Description}");
                        total += item1.Price;
                    }

                    final_total = total; //is this needed?
                    Console.WriteLine($"Your total is {final_total}");
                    double outstandingbalance;
                    // double runningbalance;

                    while (true)
                    {
                        Console.WriteLine("Please complete payment: ");
                        string usermoney = Console.ReadLine();
                        double userpay = double.Parse(usermoney);

                        if (final_total > userpay) //abstract into method
                        {
                            outstandingbalance = (final_total - userpay);
                            Console.WriteLine($"{outstandingbalance} is you balance");
                            final_total = outstandingbalance;
                        }
                        else if (userpay >= final_total)
                        {
                            change = (userpay - final_total);
                            Console.WriteLine($"{change} is your change");
                            Console.WriteLine("enjoy your meal");
                            break;
                        }
                    }

                    break;

                }

                else
                    continue;
            }
        }
    }
}
