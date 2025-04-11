using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenApplication
{
    delegate void NotificationEventHandler(string message, DateTime time); //Declare a delegate that defines the signature of the event handler method
    internal class Publisher
    {
        ////Dclare an events based on the delegate
        public event NotificationEventHandler OnSystemUpdate; 
        public event NotificationEventHandler OnSecurityAlert;
        public event NotificationEventHandler OnWelcomMessage;

        public void NotifySystemUpdate(string message)
        {
            Console.WriteLine("Publisher: Sending System Update...");
            OnSystemUpdate?.Invoke(message, DateTime.Now);//Invoke the event if there are any subscribers
        }
        public void NotifySecurityAlert(string message)
        {
            Console.WriteLine("Publisher: Sending Security Alert...");
            OnSecurityAlert?.Invoke(message, DateTime.Now);
        }

        public void NotifyWelcomMessage(string message)
        {
            Console.WriteLine("Publisher: Sending Welcome Message...");
            OnWelcomMessage?.Invoke(message, DateTime.Now);

        }
    }
}
