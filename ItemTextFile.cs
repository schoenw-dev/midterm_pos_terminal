using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CashRegApp
{
    public class ItemTextFile
    {
        public static List<Items> ReadItems(string path)
        {
            List<Items> items = new List<Items>();
            StreamReader reader = new StreamReader(path);
            string line = reader.ReadLine();
            while(line != null)
            {
                string[] itemProperties = line.Split('|');
                items.Add(new Items(itemProperties[0], double.Parse(itemProperties[1]), itemProperties[2]));
                line = reader.ReadLine();
            }
            reader.Close();
            return items;
        }

        //use the writer to give managers a method to add items to the menu?
        public static void WriteItems(List<Items> items)
        {
            StreamWriter writer = new StreamWriter("../../../ItemMenu.txt");
            foreach(Items item in items)
            {
                writer.WriteLine($"{item.ItemName},{item.ItemPrice},{item.ItemDescription}");
            }
            writer.Close();
        }
    }
    
   
}
