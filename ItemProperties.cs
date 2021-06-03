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
        public string ItemCategory { get; set; } //keep as string, or use int for multiple menus/txt files ; add item # for easy user selection?

        public ItemProperties()
        {

        }

        public ItemProperties(string itName, double itPrice, string itCategorySize, string itTopping, string itDescription, double itSubtotal, string itemCategory)
        {
            Name = itName;
            Price = itPrice;
            CategorySize = itCategorySize;
            Topping = itTopping;
            Description = itDescription;
            Subtotal = itSubtotal;
            ItemCategory = itemCategory;
        }
    }

    //using List<Items> GetItems to help testing
    //public static List<ItemProperties> GetItems() //rearrange so that item # is first? ; rearranging as txt file, no longer need method?
    //{
    //    List<ItemProperties> items = new List<ItemProperties>
    //        {
    //            new ItemProperties("Hamburger", 2.99,"Test: Hamburger", "hot"),
    //            new ItemProperties("Hot Dog", 1.99, "Test: Hot Dog", "hot"),
    //            new ItemProperties("Nachos",2.49,"Test: Nachos", "hot")
    //        };

    //    return items;
    //}
}
