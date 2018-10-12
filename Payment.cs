using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Payment
    {
        public static void startPayment(Ticket ticket, UIDiscount discount, UIPayment payment)
        {
            float price = Pricing.calcPrice(ticket, discount, payment);

            // Pay
			switch (payment) {
			case UIPayment.CreditCard:
				CreditCard c = new CreditCard ();
				c.Connect ();
				int ccid = c.BeginTransaction (price);
				c.EndTransaction (ccid);
				break;
			case UIPayment.DebitCard:
				DebitCard d = new DebitCard ();
				d.Connect ();
				int dcid = d.BeginTransaction (price);
				d.EndTransaction (dcid);
				break;
			case UIPayment.Cash:
				IKEAMyntAtare2000 coin = new IKEAMyntAtare2000 ();
				coin.starta ();
				coin.betala ((int) Math.Round(price * 100));
				coin.stoppa ();
				break;
			}
        }
    }
}
