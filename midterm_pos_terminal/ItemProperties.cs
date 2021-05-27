using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
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

}
