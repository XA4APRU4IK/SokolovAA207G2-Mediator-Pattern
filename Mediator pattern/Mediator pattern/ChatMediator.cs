using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class ChatMediator
    {
        private Dictionary<string, User> users;
        public ChatMediator()
        {
            users = new Dictionary<string, User>();
        }
        public void AddUser(User user)
        {
            users[user.Name] = user;
        }
        public void RemoveUser(User user)
        {
            users.Remove(user.Name);
        }
        public void SendMessage(User sender, string message, string recipientName)
        {
            if (users.ContainsKey(recipientName))
            {
                var recipient = users[recipientName];
                string fullMessage = $"{sender.Name} говорит: {message}";
                recipient.ReceiveMessage(fullMessage);
            }
            else
            {
                Console.WriteLine($"Пользователь {recipientName} не найден.");
            }
        }
    }
}
