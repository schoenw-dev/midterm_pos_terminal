﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CashRegApp
{
    public class ItemTextFile
    {
        public static List<ItemProperties> ReadItems(string path)
        {
            List<ItemProperties> items = new List<ItemProperties>();
            StreamReader reader = new StreamReader("../../../ItemMenu.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] itemProperties = line.Split('|');
                items.Add(new Items(itemProperties[0], double.Parse(itemProperties[1]), itemProperties[2]));
                line = reader.ReadLine();
            }
            reader.Close();
            return items;
        }
        //"../../../UserOrder"
        //"../../../ItemMenu.txt"
        //use the writer to give managers a method to add items to the menu?
        public static void WriteItems(List<ItemProperties> items)
        {
            StreamWriter writer = new StreamWriter("../../../UserOrder.txt");
            foreach (ItemProperties item in items)
            {
                writer.WriteLine($"{item.ItemName},{item.ItemPrice},{item.ItemDescription}");
            }
            writer.Close();
        }
    }
}
