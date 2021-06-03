using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegApp
{
    public class ItemProperties //or as public interface
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string CategorySize { get; set; }
        public string Topping { get; set; }
        public string Description { get; set; }
        public double Subtotal { get; set; }

        public ItemProperties()
        {

        }

        public ItemProperties(string itName, double itPrice, string itCategorySize, string itTopping, string itDescription, double itSubtotal)
        {
            Name = itName;
            Price = itPrice;
            CategorySize = itCategorySize;
            Topping = itTopping;
            Description = itDescription;
            Subtotal = itSubtotal;
        }
    }

    public class Items
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string ItemDescription { get; set; }
        public string ItemCategory { get; set; } //keep as string, or use int for multiple menus/txt files ; add item # for easy user selection?

        public Items()
        {

        }

        public Items(string name, double price, string description, string itemCategory)
        {
            ItemName = name;
            ItemPrice = price;
            ItemDescription = description;
            ItemCategory = itemCategory;
        }
        //using List<Items> GetItems to help testing
        public static List<Items> GetItems() //rearrange so that item # is first?
        {
            List<Items> items = new List<Items>
            {
                new Items("Hamburger", 2.99,"Test: Hamburger", "hot"),
                new Items("Hot Dog", 1.99, "Test: Hot Dog", "hot"),
                new Items("Nachos",2.49,"Test: Nachos", "hot")
            };

            return items;
        }
    }
}
