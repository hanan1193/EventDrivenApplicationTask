namespace EventDrivenApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Notification System");
            Publisher publisher = new Publisher();
            Subscriber1 subscriber1 = new Subscriber1("Hanan");
            Subscriber2 subscriber2 = new Subscriber2("Hala");
            SubscriberCollection subscriberCollection = new SubscriberCollection();
            // Add subsceibers to the collection
            subscriberCollection.AddSubscriber(subscriber1);
            subscriberCollection.AddSubscriber(subscriber2);
            // Subscribe to the events
            foreach (ISubscriber sub in subscriberCollection)
            {
                publisher.OnSystemUpdate += sub.HandleSystemUpdate;
                publisher.OnSecurityAlert += sub.HandleSecurityAlert;
                publisher.OnWelcomMessage += sub.HandleWelcomeMessage;

            }
            publisher.NotifySystemUpdate("System will reboot.");
            publisher.NotifySecurityAlert("Unauthorized login detected!");
            publisher.NotifyWelcomMessage("Welcome to our platform!");


        }
    }
}
