using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class OrderService
    {
        public void Order()
        {
            Console.WriteLine("Your order has been placed");
        }
    }

    public class PaymentService
    {
        public void Payment()
        {
            Console.WriteLine("Your payment has been received");
        }
    }

    public class EmailService
    {
        public void Email()
        {
            Console.WriteLine("Your order is placed, please track your order");
        }
    }

    public class InvoiceService()
    {
        public void Invoice()
        {
            Console.WriteLine("Here is your invoice for the order placed");
        }
    }
}