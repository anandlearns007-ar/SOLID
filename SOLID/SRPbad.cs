using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class OrderManager
    {
        public void CreateOrder()
        {
            Console.WriteLine("Your order has been placed");
        }

        public void Payment()
        {
            Console.WriteLine("Your payment has been completed");
        }

        public void Email()
        {
            Console.WriteLine("Your payment is complete, please track your order");
        }

        public void Invoice()
        {
            Console.WriteLine("Here is invoice for your current order");
        }
    }
}

