using SOLID;
using SOLID.Interfaces;
using SOLID.Notifications;
using SOLID.Services;

public class Program
{
    static void Main()
    {
        NotificationService service = new NotificationService();
        INotification emailNotification = new EmailNotification(); ;
        INotification smsNotification = new SMSNotification();
        service.Notify(emailNotification);
        service.Notify(smsNotification);
    }
}