using System;

namespace CashRegApp
{
    class CashPayment : Payment
    {
        public double Cash { get; set; }
        public double Change { get; set; }

        public override void GetTotalDue()
        {
            base.GetTotalDue();
            if (PaymentMethod == "CASH")
            {
                Console.WriteLine("How much cash do you have?");
                Cash = double.Parse(Console.ReadLine());
                if (Cash > Grandtotal)
                {
                    Change = Cash - Grandtotal;
                    Console.WriteLine($"Your change is {Change}");
                }
            }
        }
    }
}
