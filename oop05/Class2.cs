using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int counter = 0;

        public int TicketId { get; protected set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public decimal PriceAfterTax => Price * 1.14m;

        public bool IsBooked { get; protected set; }

        protected Ticket(string movieName, decimal price)
        {
            counter++;
            TicketId = counter;
            MovieName = movieName;
            Price = price;
            IsBooked = false;
        }

        public static int GetTotalTickets() => counter;

        // Booking Logic
        public bool Book()
        {
            if (IsBooked) return false;
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked) return false;
            IsBooked = false;
            return true;
        }

        // Printing contract
        public abstract void Print();

        // Cloning contract
        public abstract object Clone();
    }
}
