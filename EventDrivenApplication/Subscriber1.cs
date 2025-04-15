using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenApplication
{
    internal class Subscriber1:ISubscriber
    {
        public string Name { get; }
        public Subscriber1(string name)
        {
            Name = name;
        }
        // declare the methods to handle the different events.
        public void HandleSystemUpdate(string message,DateTime time)
        {
            Console.WriteLine($"[The subscriber] {Name} got System Update: {message} at {time}");
        }
        public void HandleSecurityAlert(string message, DateTime time)
        {
            Console.WriteLine($"[The subscriber] {Name} got Security Alert: {message} at {time}");
        }

        public void HandleWelcomeMessage(string message, DateTime time)
        {
            Console.WriteLine($"[The subscriber] {Name} got Welcome Message: {message} at {time}");
        }
    }
}

