using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    class MenuApp
    {
       /* public static void UserMenu()
        {
          //get menu and put in inside of a local variable
          var Locallist = ItemProperties.G


        }*/

        public static int DisplayRootMenu()
        {
            Console.WriteLine("Please select from the following options: \nEnter the number related to your desired item.");

            bool repeat = true;
            int userSelection = 0;
            while (repeat)
            {

                Console.WriteLine("\n1. Hot Food \n2. Ice Cream Cone \n3. Ice Cream Sunday");
                string userInput = Console.ReadLine();
                
                if (userInput == "1")
                {
                    userSelection = 1;
                    repeat = false;
                }
                else if (userInput == "2")
                {
                    userSelection = 2;
                    repeat = false;
                }
                else if (userInput == "3")
                {
                    userSelection = 3;
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Invalid response, please enter the number related to your selection:");
                    repeat = true;
                }
                
            }

            return userSelection;
        }


    }
}
