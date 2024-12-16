using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class User
    {
        public string Name { get; private set; }
        private List<string> chatHistory;
        public User(string name)
        {
            Name = name;
            chatHistory = new List<string>();
        }
        public void SendMessage(ChatMediator mediator, string message, string recipientName)
        {
            mediator.SendMessage(this, message, recipientName);
        }
        public void ReceiveMessage(string message)
        {
            chatHistory.Add(message);
        }
        public void ShowChatHistory()
        {
            Console.WriteLine($"История сообщений для {Name}:");
            foreach (var message in chatHistory)
            {
                Console.WriteLine(message);
            }
        }
    }
}
