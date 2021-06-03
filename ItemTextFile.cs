using System.Collections.Generic;
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
                items.Add(new ItemProperties(itemProperties[0], itemProperties[1], double.Parse(itemProperties[2]), itemProperties[3])); //int.Parse(itemProperties[4])
                line = reader.ReadLine();
            }
            reader.Close();
            return items;
        }

        //writing receipt
        public static void WriteItems(List<ItemProperties> items)
        {
            StreamWriter writer = new StreamWriter("../../../UserOrder.txt");
            var payment = new CashPayment();
            foreach (ItemProperties item in items)
            {
                writer.WriteLine($"{item.Name},{item.Price}");
                payment.Subtotal += item.Price;
            }

            payment.GetPaymentType();
            writer.WriteLine($"Subtotal: {payment.Subtotal}");
            writer.WriteLine($"Sales Tax: {payment.SalesTax}");
            writer.WriteLine($"Grandtotal: {payment.Grandtotal}");
            //writer.WriteLine($"Payment method: {}");

            writer.Close();
        }
    }
}
