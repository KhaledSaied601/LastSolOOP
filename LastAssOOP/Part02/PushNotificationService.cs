using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastAssOOP.Part02
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string msg)
        {
            Console.WriteLine($"Message for recipient: {msg}");

        }
    }
}
