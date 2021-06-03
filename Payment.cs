using CashRegApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class Payment
    {
        public static double Grandtotal { get; set; }
        public double Cash { get; set; }
        public double Change { get; set; }
        public int CheckNumber { get; set; }
        public int CCNumber { get; set; }
        public DateTime Expiration { get; set; }
        public int CCcvv { get; set; }

        public Payment()
        {

        }

        public Payment(double subtotal, double grandtotal, double cash, double change, int checkNumber, int ccNumber, DateTime expiration, int CVV)
        {
            Subtotal = subtotal;
            Grandtotal = grandtotal;
            Cash = cash;
            Change = change;
            CheckNumber = checkNumber;
            CCNumber = ccNumber;
            Expiration = expiration;
            CCcvv = CVV;
        }

        public static void GetPaymentType() //string, int - what to search by?
        {
            grandtotal = Subtotal * 0.06;
            Console.WriteLine("Cash, Check, or Credit Card?");
            if (Console.ReadLine().ToUpper() == "CASH") // case? also use int menu selection
            {
                Console.WriteLine("How much cash do you have?");
                cash = double.Parse(Console.ReadLine());
                change = cash - grandtotal;
                Console.WriteLine($"Your chang is {change}");
            }
            else if (Console.ReadLine().ToUpper() == "CHECK")
            {
                Console.WriteLine("check #?");
                checkNumber = int.Parse(Console.ReadLine());
            }
            else if (Console.ReadLine().ToUpper() == "CREDIT CARD")
            {
                Console.WriteLine("CC#?");
                ccNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("expiration?");
                expiration = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("CVV?");
                CVV = int.Parse(Console.ReadLine());
            }
        }
    }
}
