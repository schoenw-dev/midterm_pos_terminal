using System;

namespace CashRegApp
{
    class CashPayment : Payment
    {
        public decimal Cash { get; set; }
        public decimal Change { get; set; }

        public override void GetTotalDue()
        {
            base.GetTotalDue();
            if (PaymentMethod == "CASH")
            {
                Console.WriteLine("How much cash do you have?");
                Cash = decimal.Parse(Console.ReadLine());
                if (Cash > Grandtotal)
                {
                    Change = Cash - Grandtotal;
                    Console.WriteLine($"Your change is {Change:C}");
                }
            }
        }
    }
}
