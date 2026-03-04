using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===\n");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n=== Cinema Closed ===");
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    break;
                }
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets ---");
            foreach (var t in tickets)
            {
                if (t != null)
                    t.Print();   
            }
            Console.WriteLine();
        }
    }
}
