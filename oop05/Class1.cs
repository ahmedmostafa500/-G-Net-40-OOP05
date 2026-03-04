using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    // 1) Unified Printing Contract
    public interface IPrintable
    {
        void Print();
    }

    // 2) Booking & Cancellation Contract
    public interface IBookable
    {
        bool Book();
        bool Cancel();
        bool IsBooked { get; }
    }
}
