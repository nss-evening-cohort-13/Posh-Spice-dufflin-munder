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

    }

     enum Recurring {
        Weekly,
        Monthly,
        Quarterly,
        Annually
    }
}
