using System;

namespace midterm_pos_terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ItemProperties> RunningTotal = new List<ItemProperties>();
            int exam = MenuApp.DisplayRootMenu();
            Console.WriteLine(exam);
        }


    }
}
