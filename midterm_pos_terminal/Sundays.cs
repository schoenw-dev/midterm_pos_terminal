using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class Sundays : ItemProperties
    {
        public string Flavor;

        public Sundays()
        {

        }

        public Sundays(string _name, string _flavor, string _toppings, double _price)
        {
            Name = _name;
            Flavor = _flavor;
            Topping = _toppings;
            Price = _price;
        }
    }
}
