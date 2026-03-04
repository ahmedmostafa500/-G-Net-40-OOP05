using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    internal class VIPTicket:Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; } = 50;

        public VIPTicket(string movie, decimal price, bool lounge)
            : base(movie, price)
        {
            LoungeAccess = lounge;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | " +
                $"Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new VIPTicket(MovieName, Price, LoungeAccess);
        }
    }
}
