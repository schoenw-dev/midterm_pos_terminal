using System;

namespace CashRegApp
{
    class CCPayment : Payment
    {
        public int CCNumber { get; set; }
        public DateTime Expiration { get; set; }
        public int CCcvv { get; set; }

        public override void GetPaymentType()
        {
            base.GetPaymentType();

            if (PaymentMethod == "CREDIT CARD")
            {
                Console.WriteLine("CC#?");
                CCNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("expiration?");
                Expiration = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("CVV?");
                CCcvv = int.Parse(Console.ReadLine());
            }
        }
    }

    
}
