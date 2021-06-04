using System;
using System.Collections.Generic;
using System.IO;

namespace CashRegApp
{
    public class ItemTextFile
    {
        public static List<ItemProperties> ReadItemMenu()
        {
            List<ItemProperties> items = new List<ItemProperties>();
            StreamReader reader = new StreamReader("../../../ItemMenu.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] itemProperties = line.Split('|');
                items.Add(new ItemProperties(itemProperties[0], itemProperties[1], double.Parse(itemProperties[2]), itemProperties[3])); //TODO: int.Parse(itemProperties[4])
                line = reader.ReadLine();
            }
            reader.Close();
            return items;
        }

        public static void WriteItems()
        {
            List<ItemProperties> itemos = new List<ItemProperties>();

            StreamWriter writer = new StreamWriter("../../../UserOrder.txt");
            bool valid = false;
            Console.WriteLine("Cash, Check, or Credit Card?");
            string paymentMethod = Console.ReadLine().ToUpper();

            //TODO: move elsewhere?
            Payment payment = null;
            while (!valid)
            {
                switch (paymentMethod)
                {
                    case "CASH":
                        {
                            payment = new CashPayment();
                            valid = true;
                        }
                        break;
                    case "CHECK":
                        {
                            payment = new CheckPayment();
                            valid = true;
                        }
                        break;
                    case "CREDIT CARD":
                        {
                            payment = new CCPayment();
                            valid = true;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("INVALD");
                            valid = false;
                        }
                        break;
                }
            }
            payment.PaymentMethod = paymentMethod;

            foreach (ItemProperties item in itemos)
            {
                writer.WriteLine($"{item.Name},{item.Price}"); //{item.Quantity}
                payment.Subtotal += item.Price;
            }

            payment.GetTotalDue();
            writer.WriteLine($"Subtotal: {payment.Subtotal}");
            writer.WriteLine($"Sales Tax: {payment.SalesTax}");
            writer.WriteLine($"Grandtotal: {payment.Grandtotal}");
            writer.WriteLine($"Payment method: {payment.PaymentMethod}");
            writer.Close();
        }
    }
}
