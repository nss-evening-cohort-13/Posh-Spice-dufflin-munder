using System;
using System.Collections.Generic;
using System.Text;

namespace DufflinMunder
{
    class Sales
    {
        public string SalesPerson { get; set; }
        public string Client { get; set; }
        public int ClientId { get; set; }
        public int SalesTotal { get; set; }
        public Recurring Recurring { get; set; }
        public string TimeFrame { get; set; }

        public Sales (string salesPerson, string client, int clientId, int salesTotal, Recurring recurring, string timeframe)
	{
            SalesPerson = salesPerson;
            Client = client;
            ClientId = clientId;
            SalesTotal = salesTotal;
            Recurring = recurring;
            TimeFrame = timeframe;

	}
    }

     enum Recurring {
        None,
        Weekly,
        Monthly,
        Quarterly,
        Annually
    }
}
