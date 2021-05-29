using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CashRegApp
{
    public class StoreApp
    {   //MyList.Select(x=>.Name).ToArray();
        public static void UserItemMenu()
        {
            //while loop{}
            while (true)
            {

                double total = 0;
                var localList = ItemTextFile.ReadItems("../../../ItemMenu");

                Console.WriteLine("Please place your order");
                //out put list
                foreach (Items items in localList)
                {
                    //can use a loop to number the items?
                    Console.WriteLine($"{items.ItemName},{items.ItemPrice},{items.ItemDescription}");
                }

                var userchoice = Console.ReadLine().ToLower();

                //make a list that will be filled with items that the user had ordered
                List<Items> userorder = new List<Items>();


                switch (userchoice)
                {
                    case "hamburger":
                        //orders item in location 1
                        //will be expanded to give user custom options
                        userorder.Add(new Items { ItemName = "Hamburger", ItemPrice = 2.99, ItemDescription = "Test Hamburger" });

                        ItemTextFile.WriteItems(userorder);
                        foreach (Items items1 in userorder)
                        {
                            total += items1.ItemPrice;
                        }
                      /*  Console.WriteLine("Will that be all?");
                        if (userdone == "yes")
                        {
                            break;
                        } */
                        break;

                    case "hot dog":
                        //orders item in location 2
                        userorder.Add(new Items { ItemName = "Hot Dog", ItemPrice = 1.99, ItemDescription = "Test Hot Dog" });
                        ItemTextFile.WriteItems(userorder);
                        foreach (Items items1 in userorder)
                        {
                            total += items1.ItemPrice;
                        }
                      /*  Console.WriteLine("Will that be all?");
                        if (userdone == "yes")
                        {
                            break;
                        } */
                        break;

                    case "nachos":
                        //orders item in location 3
                        userorder.Add(new Items { ItemName = "Nachos", ItemPrice = 1.99, ItemDescription = "Test Nachos" });
                        ItemTextFile.WriteItems(userorder);
                        foreach (Items items1 in userorder)
                        {
                            total += items1.ItemPrice;
                        }
                      /*  Console.WriteLine("Will that be all?");
                        if (userdone == "yes")
                        {
                            break;
                        } */
                        break;

                    default:
                        Console.WriteLine("Please select an item from our menu");
                        break;


                }

                Console.WriteLine("Will that be all? Y/N");
                string userdone = Console.ReadLine().ToLower();

                if (userdone == "y")
                {

                    foreach (Items items2 in userorder)
                    {
                        Console.WriteLine($"Your order is: {items2.ItemName},{items2.ItemPrice},{items2.ItemDescription}");
                        Console.WriteLine($"Balance due = {total}");
                        break;

                    }
                }
                else
                    continue;


            }
            //Does that complete your order? If yes, break loop
            

            
        }
    }
    
    
}
