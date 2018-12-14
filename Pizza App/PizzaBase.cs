using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_App
{
    class PizzaBase
    {
        //Name(Can be: Regular, Thick, Italian)
        //Cost
        //Print();
        //PizzaBase should be passed as parameter to constructor.
       // Italian PizzaBase should cost 1.5 * Base Cost.

        public PizzaBase( Blat name, double cost)
        {
           

            this.Name = name;
            this.Cost = cost;
        }

        public Blat Name { get; set; }
        public double Cost { get; set; }

        public double GetCost()
        {
            if(Name==Blat.Italian)
            {
                return 1.5 * Cost;
            }
            return Cost;
        }

        public void Print()
        {
            Console.WriteLine($"Base: {Name} (${GetCost()})" );
        }
    }
}
