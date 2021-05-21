using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class ItemProperties //or as public interface
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Topping { get; set; }
    }
}
