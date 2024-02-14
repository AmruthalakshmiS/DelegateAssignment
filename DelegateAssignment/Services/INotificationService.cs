using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment.Services
{
    public class INotificationService
    {
        void Notification(string message)
        {
            Console.WriteLine(message);
        }
    }
}
