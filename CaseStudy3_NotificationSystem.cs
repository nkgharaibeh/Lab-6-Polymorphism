using System;
using System.Collections.Generic;

namespace CaseStudy3_NotificationSystem
{
    // Abstract base class: all notifications must implement SendMessage.
    abstract class Notification
    {
        public abstract void SendMessage(string message);
    }

    class EmailNotification : Notification
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }

    class SMSNotification : Notification
    {
        public override void SendMessage(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphic list of notifications (email + SMS).
            List<Notification> notifications = new List<Notification>
            {
                new EmailNotification(),
                new SMSNotification()
            };

            foreach (var n in notifications)
            {
                n.SendMessage("Your report is ready.");
            }

            Console.ReadKey();
        }
    }
}

/*
LAB MESSAGE:
- Abstract class ensures a uniform structure (SendMessage).
- Different channels (Email, SMS) implement their own sending logic.
- Real-world example of polymorphism in communication systems.
*/
