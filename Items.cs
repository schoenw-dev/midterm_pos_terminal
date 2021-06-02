using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegApp
{
    public class Items
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string ItemDescription { get; set; }

        public Items()
        {

        }

        public Items(string name, double price, string description)
        {
            ItemName = name;
            ItemPrice = price;
            ItemDescription = description;
        }
        //using List<Items> GetItems to help testing
        public static List<Items> GetItems()
        {
            List<Items> items = new List<Items>
            {
                new Items("Hamburger", 2.99,"Test: Hamburger"),
                new Items("Hot Dog", 1.99, "Test: Hot Dog"),
                new Items("Nachos",2.49,"Test: Nachos")
            };

            return items;
        }


    }

}
