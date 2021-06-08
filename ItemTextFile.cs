using System;
using System.Collections.Generic;
using System.IO;

namespace CashRegApp
{
    public class ItemTextFile
    {
        //List<ItemProperties> userOrder = new List<ItemProperties>();
        //var countItemsList = userOrder.Distinct().ToList();

        public static List<ItemProperties> ReadItemMenu()
        {
            List<ItemProperties> items = new List<ItemProperties>();
            StreamReader reader = new StreamReader("../../../ItemMenu.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] itemProperties = line.Split('|');
                items.Add(new ItemProperties(itemProperties[0], itemProperties[1], decimal.Parse(itemProperties[2]), itemProperties[3])); //TODO: int.Parse(itemProperties[4]) ; index 2 as currency
                line = reader.ReadLine();
            }
            reader.Close();
            return items;
        }

        public static Payment WriteItems(List<ItemProperties> items)
        {
            StreamWriter writer = new StreamWriter("../../../UserOrder.txt");
            bool valid = false;
            Console.WriteLine("\nCash, Check, or Credit Card?");
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
                    case "CARD":
                        {
                            payment = new CCPayment();
                            valid = true;
                        }
                        break;
                    default: //TODO: improved catch?
                        {
                            Console.WriteLine("INVALD");
                            valid = false;
                        }
                        break;
                }
            }
            payment.PaymentMethod = paymentMethod;

            foreach (ItemProperties item in items)
            {
                //writer.WriteLine($"{item.Name} | x{userOrder.Where(x => x.Name == item.Name).ToList().Count} | {item.Price:C}"); //TODO: {item.Quantity}
                writer.WriteLine($"{item.Name} | {item.Price:C}");
                payment.Subtotal += item.Price;
            }

            payment.GetTotalDue();
            writer.WriteLine($"Subtotal: {payment.Subtotal:C}");
            writer.WriteLine($"Sales Tax: {payment.SalesTax:C}");
            writer.WriteLine($"Grandtotal: {payment.Grandtotal:C}");
            writer.WriteLine($"Payment method: {payment.PaymentMethod}");
            writer.Close();

            return payment;
        }
    }
}
