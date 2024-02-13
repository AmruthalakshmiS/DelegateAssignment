using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment
{
    public class UserRepository
    {
        private readonly List<User> _users = new();

        public void AddUser(User user)
        { 
            _users.Add(user);
        }

        public void UpdateUser(User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (user != null)
            {
                user.Name = updatedUser.Name ?? user.Name;
                user.Email = updatedUser.Email ?? user.Email;
                user.Contact = updatedUser.Contact ?? user.Contact;
            }
        }

        public void RemoveUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public IEnumerable<User> ShowUsers()
        {
            return _users.AsReadOnly();
        }

        public User GetUserById(int id)
        {
            return _users.Find(u => u.Id == id);
        }

    }
}
