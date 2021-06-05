using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class Bowls : ItemProperties
    {
        public string _flavors { get; set; }

        public Bowls()
        {

        }
        public Bowls (string flavor)
        {
            _flavors = flavor;
        }

        //generate list of flavors: vanilla, chocolate, stawberry, superman, butter pecan
        //generate list of toppings: m&m's, reases pieces, sprinkles, oreos
        //generate list of sizes: small, medium, large

        public static List<Bowls> GetFlavors()
        {
            List<Bowls> bowls = new List<Bowls>
            {
                new Bowls ("vanilla"),
                new Bowls ("chocolate"),
                new Bowls ("strawberry"),
                new Bowls ("superman"),
                new Bowls ("butter pecan")


            };

            return bowls;

        }
    }
}
