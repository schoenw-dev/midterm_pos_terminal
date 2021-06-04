using System;
using System.Collections.Generic;
using System.IO;

namespace CashRegApp
{
    public class ItemTextFile
    {
        public static List<ItemProperties> ReadItemMenu()
        {
            List<ItemProperties> items = new List<ItemProperties>();
            StreamReader reader = new StreamReader("../../../ItemMenu.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] itemProperties = line.Split('|');
                items.Add(new ItemProperties(itemProperties[0], itemProperties[1], double.Parse(itemProperties[2]), itemProperties[3])); //int.Parse(itemProperties[4])
                line = reader.ReadLine();
            }
            reader.Close();
            return items;
        }

        //requesting order ; ask if menu needs to be visible again
        //public static void UserOrder()
        //{
        //    while (true)
        //    {
        //        var userSelection = new ItemProperties();

        //        Console.WriteLine("Please place your order");

        //        foreach (ItemProperties items in userSelection) // replace with providing txt file
        //        {
        //            Console.WriteLine($"{items.ItemNumber},{items.Name},{items.Price}");
        //        }

        //        var userchoice = Console.ReadLine().ToLower();

        //        if (userchoice != userSelection.ItemNumber)
        //        {
        //            //case "1":
        //            //    //orders item in location 1
        //            //    //will be expanded to give user custom options
        //            //    userorder.Add(new ItemProperties { Name = "Hamburger", Price = 2.99, Description = "Test Hamburger" });

        //            //    break;

        //            //case "2":
        //            //    //orders item in location 2
        //            //    userorder.Add(new ItemProperties { Name = "Hot Dog", Price = 1.99, Description = "Test Hot Dog" });

        //            //    break;

        //            //case "3":
        //            //    //orders item in location 3
        //            //    userorder.Add(new ItemProperties { Name = "Nachos", Price = 1.99, Description = "Test Nachos" });

        //            //    break;

        //            //default:
        //            Console.WriteLine("Please select an item from our menu");
        //            continue;
        //        }

        //        Console.WriteLine("Will that be all? Y/N"); //change to accept new #, otherwise use N to exit loop
        //        string userdone = Console.ReadLine().ToLower();

        //        if (userdone != "n")
        //        {
        //            ItemTextFile.WriteItems(userSelection);
        //            var finalList = ItemTextFile.ReadItems("../../../UserOrder.txt"); //could use this to create a record of user purchases
        //            Console.WriteLine("YOUR FINAL ORDER IS");

        //            foreach (ItemProperties item1 in userSelection)
        //            {
        //                Console.WriteLine($"{item1.Name},{item1.Price}");
        //                Subtotal += item1.Price;
        //            }

        //            final_total = total; //is this needed?
        //            Console.WriteLine($"Your total is {final_total}");
        //            double outstandingbalance;
        //            // double runningbalance;

        //            while (true)
        //            {
        //                Console.WriteLine("Please complete payment: ");
        //                string usermoney = Console.ReadLine();
        //                double userpay = double.Parse(usermoney);

        //                if (final_total > userpay) //abstract into method
        //                {
        //                    outstandingbalance = (final_total - userpay);
        //                    Console.WriteLine($"{outstandingbalance} is you balance");
        //                    final_total = outstandingbalance;
        //                }
        //                else if (userpay >= final_total)
        //                {
        //                    change = (userpay - final_total);
        //                    Console.WriteLine($"{change} is your change");
        //                    Console.WriteLine("enjoy your meal");
        //                    break;
        //                }
        //            }

        //            break;

        //        }

        //        else
        //            continue;
        //    }

        //writing receipt
        public static List<ItemProperties> WriteItems()
        {
            List<ItemProperties> itemos = new List<ItemProperties>();

            StreamWriter writer = new StreamWriter("../../../UserOrder.txt");
            var payment = new CashPayment();
            foreach (ItemProperties item in itemos)
            {
                writer.WriteLine($"{item.Name},{item.Price}");
                payment.Subtotal += item.Price;
            }

            payment.GetTotalDue();
            writer.WriteLine($"Subtotal: {payment.Subtotal}");
            writer.WriteLine($"Sales Tax: {payment.SalesTax}");
            writer.WriteLine($"Grandtotal: {payment.Grandtotal}");
            //writer.WriteLine($"Payment method: {}");

            writer.Close();
            return itemos;
        }
    }
}
