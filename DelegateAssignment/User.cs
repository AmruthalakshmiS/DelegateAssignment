using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment
{
    public class User
    {
        private static int _lastId = 0;
        public int Id { get; private set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Contact { get; set; }

        public User(){
            this.Id = ++_lastId;
            //this.Name = name;
            //this.Email = email;
            //this.Contact = contact;
         }

    }
}
