using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment.Services
{
    public class NotificationService : INotificationService
    {
        public class SmsService
        {
            public void Notify(string message)
            {
                Console.WriteLine($"SMS: {message}");
            }
        }

        public class EmailService
        {
            public void Notify(string message) 
            {
                Console.WriteLine($"Email: {message}");
            }
        }

        public class PushService
        {
            public void Notify(string message)
            {
                Console.WriteLine($"Push: {message}");
            }
        }


    }
}
