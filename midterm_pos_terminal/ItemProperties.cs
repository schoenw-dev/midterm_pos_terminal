﻿using System;
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
    }
}
