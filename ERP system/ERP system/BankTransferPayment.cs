using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_system
{
    public class BankTransferPayment : Ipayment
    {
        public void process(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Bank Transfer.");
        }
    }
}
