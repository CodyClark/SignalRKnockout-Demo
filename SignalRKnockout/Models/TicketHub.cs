
using SignalR.Hubs;

namespace SignalRKnockout.Models
{
    public class TicketHub : Hub
    {
        static int TotalTickets = 10;

        public void GetTicketCount()
        {
            Clients.updateTicketCount(TotalTickets);
        }

        public void BuyTicket()
        {
            if (TotalTickets > 0)
                TotalTickets -= 1;
            Clients.updateTicketCount(TotalTickets);
        }
    }
}