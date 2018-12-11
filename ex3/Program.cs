using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3.rate_room_si_hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Rate R1 = new Rate
            {Amount=1000,
            Currency="400 lei",

            };

            Room room1 = new Room
            {
                Name = "liliac",
                DailyRate = ,
                Adults = 2,
                Children = 0,

            };
            Room room2 = new Room
            {
                Name = "orange",
                DailyRate ="ron" ,
                Adults = 2,
                Children = 0,

            };

            Hotel hotel1 = new Hotel
            {
                Name = "vlad",
                City = "Iasi",
                Stars = "4stele",

            }
            ;
            var listacamere = new List<Room>();
            listacamere.Add(room1);
            listacamere.Add(room2);


            var str = R1.Print();

            var str2 = room1.Print();
            var str3 = hotel1.Print();

           Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.ReadLine();
        }
    }
}
