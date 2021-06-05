using System;

namespace CashRegApp
{
    class CheckPayment : Payment
    {
        public int CheckNumber { get; set; }

        public override void GetTotalDue()
        {
            base.GetTotalDue();
            if (PaymentMethod == "CHECK")
            {
                Console.WriteLine("check #?");
                CheckNumber = int.Parse(Console.ReadLine());
            }
        }
    }

    
}
