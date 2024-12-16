using System;
using System.Collections.Generic;
using Mediator_pattern;
public class Program
{
    public static void Main()
    {
        ChatMediator mediator = new ChatMediator();

        User alice = new User("Алиса");
        User bob = new User("Боб");

        mediator.AddUser(alice);
        mediator.AddUser(bob);

        alice.SendMessage(mediator, "Привет, Боб!", "Боб");
        bob.SendMessage(mediator, "Привет, Алиса!", "Алиса");

        alice.ShowChatHistory();
        bob.ShowChatHistory();

        mediator.RemoveUser(bob);
    }
}
