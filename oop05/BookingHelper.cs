using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    internal class BookingHelper
    {
        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("--- BookingHelper.PrintAll ---");
            foreach (var item in items)
            {
                item.Print();
            }
        }
    }
}
