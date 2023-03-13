using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public struct Ticket
    {
        public int TicketNumber;
        public int Price;

        public Ticket(int tn, int p)
        {
            TicketNumber = tn;
            Price = p;
        }
    }
}
