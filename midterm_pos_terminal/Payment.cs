using System;
using System.Collections.Generic;
using System.Text;

namespace midterm_pos_terminal
{
    public class Payment : ItemProperties
    {
        public static double Grandtotal { get; set; }
        public double Cash { get; set; }
        public double Change { get; set; }
        public int CheckNumber { get; set; }
        public int CCNumber { get; set; }
        public DateTime Expiration { get; set; }
        public int CCcvv { get; set; }


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

        public static string GetPaymentType() //string, int - what to search by?
        {
            Console.WriteLine("Cash, Check, or Credit Card?");
            if (Console.ReadLine().ToUpper() == "CASH") // case? also use int menu selection
            {
                Console.WriteLine("How much cash do you have?");
                cash = double.Parse(Console.ReadLine());
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

        public static double GetCashChange()
        {
            change = cash - grandtotal;
            return change;
        }


    }
}
