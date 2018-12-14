using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_App
{
    class PizzaTopping
    {
//Name(Can be: Cheese, Meat, Vegetable)
//Cost
//Print();
//Meat should display the name UPPERCASE.
public PizzaTopping(string name)
        {
            this.Name = name;
            this.Cost = Cost;

        }
        public string Name { get; set; }
        public double Cost { get; set; }
        public void Print()
        {
            Console.WriteLine($"\t{Name} (${Cost})");
        }
    }
}
