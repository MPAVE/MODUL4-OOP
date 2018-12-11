using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3.rate_room_si_hotel
{
    class Room
    {
        public String Name { get; set; }
        public Rate DailyRate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }

        public decimal GetPriceForDays(int numberOfDays)
        {
            return numberOfDays * DailyRate.Amount;
        }
        public string Print()
        {
            return $"camera cu numele {Name} are pretul de {DailyRate.Amount} {DailyRate.Currency}si poate sta {Adults} si  {Children}";
        }
    }
}
