using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class ConesSoftServe : ItemProperties
    {
        public ConesSoftServe(string name, double price, string size, string topping)
        {
            Name = name;
            Price = price;
            Size = size;
            Topping = topping;
        }
    }
}
