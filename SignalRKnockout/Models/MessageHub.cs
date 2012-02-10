using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace SignalRKnockout.Models
{
    public class MessageHub : Hub
    {
        public static int MessageCount = 0;

        public void GetMessageCount()
        {
            Clients.updateMessageCount(MessageCount);

            for (var x = 0; x < 5; x++)
            {
                Clients.displayMessage("this is a test message:" + x.ToString());
                MessageCount = MessageCount + 1;
                Clients.updateMessageCount(MessageCount);
            }
        }

        public void CheckForNewMessages()
        {
            Clients.displayMessage("this is a NEW message");

            MessageCount = MessageCount + 1;
            Clients.updateMessageCount(MessageCount);
        }
    }
}