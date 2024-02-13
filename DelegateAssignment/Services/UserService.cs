using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAssignment.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository = new();
        public UserService() { }

        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        public void RemoveUser(int id)
        {
            _userRepository.RemoveUser(id);
        }

        public void UpdateUser(User user) {
            _userRepository.UpdateUser(user);
        }

        public IEnumerable<User> ShowUsers()
        {
            return _userRepository.ShowUsers();
        }
    }
}
