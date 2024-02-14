using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment.Services
{
    public class Notification : INotificationService
    {
        public class SmsService
        {
            public void Notify(string message)
            {
                Console.WriteLine($"SMS notification, {message}");
            }
        }

        public class EmailService
        {
            public void Notify(string message) 
            {
                Console.WriteLine($"Email notification, {message}");
            }
        }

        public class PushService
        {
            public void Notify(string message)
            {
                Console.WriteLine($"Email notification, {message}");
            }
        }


    }
}
