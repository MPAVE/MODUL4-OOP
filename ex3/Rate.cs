using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3.rate_room_si_hotel
{
    class Rate
    { public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Rate(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;

        }

        public string Print()
        {
            return $"{Amount} si {Currency}.";
        }
    }
}
