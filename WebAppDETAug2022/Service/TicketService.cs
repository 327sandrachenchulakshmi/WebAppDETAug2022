using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Service
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        //static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket{Id=1,Category="PlatinumPlus", Price=5000, MaxLimit=200000 },
                    new Ticket{Id=2,Category="Platinum", Price=4000, MaxLimit=300000 },
                    new Ticket{Id=3,Category="Gold", Price=3000, MaxLimit=500000 },
                    new Ticket{Id=4,Category="Silver", Price=2000, MaxLimit=500000 },
                    new Ticket{Id=5,Category="General", Price=800, MaxLimit=1000000 }
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p. Id== id);

        public static void Add(Ticket Ticket)
        {
            //Ticket.Id = nextId++;
            Tickets.Add(Ticket);
        }

        public static void Delete(Ticket Ticket)
        {
            //var Tickets = Get(id);
            //if (Ticket is null)
            //    return;

            Tickets.Remove(Ticket);
        }

        public static void Update(Ticket Ticket)
        {
            var index = Tickets.FindIndex(p => p.Id == Ticket.Id);
            if (index == -1)
                return;

            Tickets[index] = Ticket;
        }
    }
}

