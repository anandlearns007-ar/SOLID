using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services
{
    public class NotificationService
    {
        public void Notify(INotification notification)
        {
            notification.Send();
        }
    }
}
