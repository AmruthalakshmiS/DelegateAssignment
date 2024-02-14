using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateAssignment.Services.NotificationService;

namespace DelegateAssignment.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository = new();


        //public UserService() { }
        public UserService()
        {
            SmsService smsService = new();
            EmailService emailService = new();
            PushService pushService = new();

            _userRepository.OnChange += (sender, e) =>
            {
                string message = $"{e.Action} notification => {e.User.Id}, {e.User.Name}\n";
                smsService.Notify(message);
                emailService.Notify(message);
                pushService.Notify(message);
            };
        }


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

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

    }
}
