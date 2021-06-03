using System;

namespace CashRegApp
{
    abstract class Payment
    {
        public double Subtotal { get; set; }
        public double SalesTax { get; set; } = 0.06;
        public double Grandtotal { get; set; }
        public string PaymentMethod { get; set; }

        public virtual void GetPaymentType()
        {
            Grandtotal = Subtotal * SalesTax;
            Console.WriteLine("Cash, Check, or Credit Card?");
            PaymentMethod = Console.ReadLine().ToUpper();
        }
        //switch statement to determine payment type, which is used in child class
    }
}
