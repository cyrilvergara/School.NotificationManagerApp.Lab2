using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManagerApp
{
    internal class Subscriber
    {
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        private static List<Subscriber> allSubscribers = new List<Subscriber>();

        public Subscriber(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;

            allSubscribers.Add(this);
        }

        public static List<Subscriber> GetAllSubscribers()
        {
            return allSubscribers;
        }
    }
}
