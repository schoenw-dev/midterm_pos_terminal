using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class ConesSoftServe : ItemProperties
    {
        public static bool Dipped { get; set; }
        //public static string ConeType { get; set; }
        public string SoftServeFlavor { get; set; }

        public ConesSoftServe(string name, double price, string description, double subtotal, string size, string conetype, bool dipped, string softServeFlavor)
        {
            Name = name;
            Price = price;
            Subtotal = subtotal;
            CategorySize = size; //feature #1
            //ConeType = conetype; //feature #2
            Dipped = dipped; // feature #3
            SoftServeFlavor = softServeFlavor; //feature #4 - other 'list' of flavors to reference?

           // Name = $"{_hotMain.Name} with {_side.Name}";
            //Subtotal = Subtotal + sizes.Price + cones.Price + dipped.Price + flavors.Price;
           // ConeType.ReferenceEquals(Console.ReadLine(), ConeType.sugar);
        }

        //public static List<string> ChooseSize() //feature #1; method to actually choose size, not just list out
        //{
        //    List<string> sizes = new List<string> //add prices
        //    {
        //        "kids", "small", "medium", "large"
        //    };

        //    return sizes;
        //}

        //REFERENCE FOR STRUCT: https://stackoverflow.com/questions/14744123/can-you-use-enum-for-double-variables

        public struct ChooseSize
        {
            public const double kids = .25;
            public const double small = .75;
            public const double medium = 1.50;
            public const double large = 4;
        }

        //public static List<string> ChooseConeType() //feature #2; method to actually choose cone type, not just list out; add prices
        //{
        //    List<string> cones = new List<string>
        //    {
        //        "sugar", "waffle", "cake", "no cone"
        //    };

        public struct ConeType
        {
            public const double sugar = 1;
            public const double waffle = 2;
            public const double cake = .50;
            public const double none = 0;
        }

        public void ChocolateDipped() // feature #3
        {
            Console.WriteLine("chocolate dipped?");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Dipped = true;
                //subtotal = subtotal + 0.50;
            }
            else
            {
               // dipped = false;
            }
        }

        public static List<string> ChooseCreamFlavor() //feature #4; method to actually choose flavor, not just list out
        {
            List<string> flavors = new List<string>
            {
                "vanilla", "chocolate", "strawberry", "mint chocolate chip"
            };

           // Subtotal = Subtotal + 2;
            return flavors;
        }
    }
}
