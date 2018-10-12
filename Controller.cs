using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Controller
    {
        public static void startTransaction(UIInfo info)
        {
            Ticket ticket = makeTicket(info.From, info.To, info.Class, info.Way);
            Payment.startPayment(ticket,info.Discount, info.Payment);
        }

        public static Ticket makeTicket(string from, string to, UIClass cls, UIWay way)
        {
            Ticket ticket = new Ticket(from, to, cls, way);
            return ticket;                
        }       
    }
}
