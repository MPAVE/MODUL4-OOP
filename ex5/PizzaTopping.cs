using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5.pizza
{
    class PizzaTopping
    {
        public string Topping { get; set; }
        public double Cost { get; set; }
        public void Print()
        {
            Console.WriteLine("Toping: " + Topping);
            Console.WriteLine("Pretul:" + Cost);
        }
    }
}
