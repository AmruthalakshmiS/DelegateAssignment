using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment.Services
{
    public class ChangedEvents: EventArgs
    {

            public User User { get; set; }

            public string Action { get; set; }

            public ChangedEvents(User user, string action)
            {
                User = user;
                Action = action;
            }
    }
}
