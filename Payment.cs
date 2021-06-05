using System;

namespace CashRegApp
{
    public abstract class Payment
    {
        public decimal Subtotal { get; set; }
        public decimal SalesTax { get; set; }
        public decimal Grandtotal { get; set; }
        public string PaymentMethod { get; set; }

        public virtual void GetTotalDue()
        {
            SalesTax = Subtotal * 0.06M;
            Grandtotal = Subtotal + SalesTax;
        }
        //switch statement to determine payment type, which is used in child class
    }
}
