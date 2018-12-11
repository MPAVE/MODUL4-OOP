using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3.rate_room_si_hotel
{
    class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Stars { get; set; }
       public  List<Room> listacamere { get; set; }

        public string Print()
        {
            return $"hotelul cu numele {Name} este in orasul {City} si are {Stars} .";
        }

        public decimal pricefornumberofrooms (Room room, int nr)
        {
           return nr * room.DailyRate.Amount;
        }
    }
}
