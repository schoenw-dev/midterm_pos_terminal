using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace midterm_pos_terminal
{
    class MenuFilesIO

    {
        public class MenuTextFile
        {
            public static void WriteMenu(List<ItemProperties> itemProperties)
            {
                StreamWriter writer = new StreamWriter("../../../TestMenu.txt");

                foreach (ItemProperties itemProperties1 in itemProperties)
                {
                    writer.WriteLine($"{itemProperties1.Name}, {itemProperties1.Price},{itemProperties1.CategorySize},{itemProperties1.Topping},{itemProperties1.Topping},{itemProperties1.Subtotal}");
                }

            }
            public static List<ItemProperties> GetMenu(string path)
            {
                List<ItemProperties> itemProperties = new List<ItemProperties>();
                StreamReader reader = new StreamReader("../../../TestMenu.txt");
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] itemproperties = line.Split("|");
                    itemProperties.Add(itemProperties[0], double.Parse(itemProperties[1]), itemProperties[2], itemProperties[3], itemProperties[4], double.Parse(itemProperties[5])));
                    line = reader.ReadLine();
                }

                reader.Close();
                return itemProperties;




            }



        }

        }
}
