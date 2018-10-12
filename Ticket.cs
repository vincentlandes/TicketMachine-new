using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Ticket
    {
        public string from, to;
        public UIClass cls;
        public UIWay way;

        public Ticket(string from, string to, UIClass cls, UIWay way)
        {
            this.from = from;
            this.to = from;
            this.cls = cls;
            this.way = way;
        }
    }
}
