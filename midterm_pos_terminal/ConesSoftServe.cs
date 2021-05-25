using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class ConesSoftServe : ItemProperties
    {
        public static bool Dipped { get; set; }

        public ConesSoftServe(string name, double price, string size, string description, double subtotal, bool dipped)
        {
            Name = name;
            Price = price;
            CategorySize = size;
            Subtotal = subtotal;
            Dipped = dipped;
        }

        public static List<string> ChooseCreamFlavor()
        {
            List<string> flavors = new List<string>
            {
                "vanilla", "chocolate", "strawberry", "mint chocolate chip"
            };

            return flavors;
        }

        public void ChocolateDipped()
        {
            Console.WriteLine("chocolate dipped?");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Dipped = true;
                Subtotal = Subtotal + 0.50;
            }
            else
            {
                Dipped = false;
                Price = 1.50;
            }
        }
    }
}
