using System;
using System.Collections.Generic;

namespace CashRegApp
{
    //public class StoreApp
    //{
    //    public static void UserItemMenu()
    //    {
    //        List<ItemProperties> userorder = new List<ItemProperties>();
    //        decimal total = 0;
    //        decimal final_total;
    //        decimal change;

    //        while (true)
    //        {
    //            var localMenu = ItemTextFile.ReadItems("../../../ItemMenu");

    //            Console.WriteLine("Please place your order");

    //            foreach (ItemProperties items in localMenu) // replace with providing txt file
    //            {
    //                Console.WriteLine($"{items.ItemNumber},{items.Name},{items.Price},{items.Description}");
    //            }

    //            var userchoice = Console.ReadLine().ToLower();

    //            if (userchoice != userorder.ItemNumber)
    //            {
                    
    //                Console.WriteLine("Please select an item from our menu");
    //                continue;
    //            }

    //            Console.WriteLine("Will that be all? Y/N");
    //            string userdone = Console.ReadLine().ToLower();

    //            if (userdone != "n")
    //            {
    //                ItemTextFile.WriteItems(userorder);
    //                var finalList = ItemTextFile.ReadItems("../../../UserOrder.txt"); //could use this to create a record of user purchases
    //                Console.WriteLine("YOUR FINAL ORDER IS");

    //                foreach (ItemProperties item1 in userorder)
    //                {
    //                    Console.WriteLine($"{item1.Name},{item1.Price},{item1.Description}");
    //                    total += item1.Price;
    //                }

    //                final_total = total; //is this needed?
    //                Console.WriteLine($"Your total is {final_total}");
    //                decimal outstandingbalance;
    //                // decimal runningbalance;

    //                while (true)
    //                {
    //                    Console.WriteLine("Please complete payment: ");
    //                    string usermoney = Console.ReadLine();
    //                    decimal userpay = decimal.Parse(usermoney);

    //                    if (final_total > userpay) //abstract into method
    //                    {
    //                        outstandingbalance = (final_total - userpay);
    //                        Console.WriteLine($"{outstandingbalance} is you balance");
    //                        final_total = outstandingbalance;
    //                    }
    //                    else if (userpay >= final_total)
    //                    {
    //                        change = (userpay - final_total);
    //                        Console.WriteLine($"{change} is your change");
    //                        Console.WriteLine("enjoy your meal");
    //                        break;
    //                    }
    //                }

    //                break;

    //            }

    //            else
    //                continue;
    //        }
    //    }
    //}
}
