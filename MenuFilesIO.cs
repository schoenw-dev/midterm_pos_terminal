using CashRegApp;
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
            public void WriteMenu(List<ItemProperties> itemProperties)
            {
                StreamWriter writer = new StreamWriter("../../../TestMenu.txt");

                foreach (ItemProperties itemProperties1 in itemProperties)
                {
                    writer.WriteLine($"{itemProperties1.Name}, {itemProperties1.Price},{itemProperties1.CategorySize},{itemProperties1.Topping},{itemProperties1.Topping},{itemProperties1.Subtotal}");
                }
            }

            public List<ItemProperties> GetMenu(string path)
            {
                List<ItemProperties> itemProperties = new List<ItemProperties>();
                StreamReader reader = new StreamReader("../../../TestMenu.txt");
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] itemproperties = line.Split("|");
                    itemProperties.Add(new ItemProperties (itemproperties[0], double.Parse(itemproperties[1]), itemproperties[2], itemproperties[3], itemproperties[4], double.Parse(itemproperties[5]), itemproperties[6]));
                    line = reader.ReadLine();
                }

                reader.Close();
                return itemProperties;
            }
        }
    }
}
