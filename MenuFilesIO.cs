using System.Collections.Generic;
using System.IO;


namespace CashRegApp
{
    public class MenuFilesIO
    {
        public class MenuTextFile
        {
            public void WriteMenu(List<ItemProperties> itemProperties)
            {
                StreamWriter writer = new StreamWriter("../../../TestMenu.txt");

                foreach (ItemProperties userOrder in itemProperties)
                {
                    writer.WriteLine($"{userOrder.ItemNumber}, {userOrder.Name}, {userOrder.Price}, {userOrder.Description}"); //, {userOrder.Quantity}
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
                    itemProperties.Add(new ItemProperties (itemproperties[0], itemproperties[1], double.Parse(itemproperties[2]), itemproperties[3])); //, int.Parse(itemproperties[4])
                    line = reader.ReadLine();
                }

                reader.Close();
                return itemProperties;
            }
        }
    }
}
