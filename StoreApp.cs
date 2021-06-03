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
            List<Items> userorder = new List<Items>();
            double total = 0;
            double final_total;
            double change;

            while (true)
            {
                var localMenu = ItemTextFile.ReadItems("../../../ItemMenu");

                Console.WriteLine("Please place your order");

                foreach (Items items in localMenu)
                {
                    Console.WriteLine($"{items.ItemName},{items.ItemPrice},{items.ItemDescription}");
                }

                var userchoice = Console.ReadLine().ToLower();

                switch (userchoice)
                {
                    case "1":
                        //orders item in location 1
                        //will be expanded to give user custom options
                        userorder.Add(new Items { ItemName = "Hamburger", ItemPrice = 2.99, ItemDescription = "Test Hamburger" });

                        break;

                    case "2":
                        //orders item in location 2
                        userorder.Add(new Items { ItemName = "Hot Dog", ItemPrice = 1.99, ItemDescription = "Test Hot Dog" });

                        break;

                    case "3":
                        //orders item in location 3
                        userorder.Add(new Items { ItemName = "Nachos", ItemPrice = 1.99, ItemDescription = "Test Nachos" });

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

                    foreach (Items item1 in userorder)
                    {
                        Console.WriteLine($"{item1.ItemName},{item1.ItemPrice},{item1.ItemDescription}");
                        total += item1.ItemPrice;
                    }

                    final_total = total;
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
