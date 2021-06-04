using System;

namespace CashRegApp
{
    abstract class Payment
    {
        public double Subtotal { get; set; }
        public double SalesTax { get; set; }
        public double Grandtotal { get; set; }
        public string PaymentMethod { get; set; }

        public virtual void GetTotalDue()
        {
            SalesTax = Subtotal * 0.06;
            Grandtotal = Subtotal + SalesTax;
        }
        //switch statement to determine payment type, which is used in child class
    }
}
