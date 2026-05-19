using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Interfaces;

namespace SOLID.Notifications
{
    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Send Email Notifications");
        }
    }
}
