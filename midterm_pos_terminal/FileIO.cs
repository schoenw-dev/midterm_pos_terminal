using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace midterm_pos_terminal
{
    public class FileIO

    {  //missing specific referneces
        
        public static void WriteMenu (List<ItemProperties> itemProperties)
        {
            StreamWriter writer = new StreamWriter("", true);
            foreach (ItemProperties itemProperties1 in itemProperties)
            {
                writer.WriteLine();
            }
        }

        public static List<ItemProperties> GetMenu(string path)
        {
            //define file path later
            List<ItemProperties> itemProperties = new List<ItemProperties>();
            StreamReader reader = new StreamReader("");
            string line = reader.ReadLine();
            while (line != null)
            {
                //nail down lists and properites of our items
            }
            reader.Close();
            return itemProperties;
        }
    }
}
