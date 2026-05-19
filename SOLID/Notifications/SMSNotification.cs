using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Interfaces;

namespace SOLID.Notifications
{
    public class SMSNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Send SMS Notifications");
        }   
    }
}

