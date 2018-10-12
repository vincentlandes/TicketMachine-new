using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Pricing
    {
        public static float calcPrice(Ticket ticket, UIDiscount discount, UIPayment payment) 
        {
            float price = 0;
            int tariefeenheden = Tariefeenheden.getTariefeenheden (ticket.from, ticket.to);
            int tableColumn;
            
            // First based on class
			switch (ticket.cls) {
			case UIClass.FirstClass:
				tableColumn = 3;
				break;
			default:
				tableColumn = 0;
				break;
			}

            // Then, on the discount
            switch (discount) {
			case UIDiscount.TwentyDiscount:
				tableColumn += 1;
				break;
			case UIDiscount.FortyDiscount:
				tableColumn += 2;
				break;
			}

            // Get price
			price = PricingTable.getPrice (tariefeenheden, tableColumn);
			if (ticket.way == UIWay.Return) {
				price *= 2;
			}
			// Add 50 cent if paying with credit card
			if (payment == UIPayment.CreditCard) {
				price += 0.50f;
			}

            return price;
        }
    }
}
