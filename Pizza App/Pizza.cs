using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_App
{
    class Pizza
    {
   //     PizzaBase
   //List<PizzaTopping>
   //AddTopping();
   //     CalculateTotalCost();
   //     Print();

        public Pizza(PizzaBase pizzaBase)
        {
            this.Name = Name;
            this.PizzaBase = pizzaBase;
            this.PizzaTopping = new List<PizzaTopping>();
        }
        public string Name { get; set; }
        public PizzaBase PizzaBase { get; set; }
        public List<PizzaTopping> PizzaTopping { get; set; }

        public void AddTopping (PizzaTopping pizzaTopping)
        {
            PizzaTopping.Add(pizzaTopping);
        }

        public double CalculateTotalCost()
        {
            double c = 0;
            c = c + this.PizzaBase.GetCost();
            foreach (var tooping in PizzaTopping)
            {
                c = c + tooping.Cost;
            }
            return c;
        }

        public void Print()
        {
            Console.WriteLine($"Pizza:{Name}");
            this.PizzaBase.Print();
            Console.WriteLine("Toppings:");
            foreach (var topping in PizzaTopping)
            {
                topping.Print();
            }
            Console.WriteLine("Total cost: $" +this.CalculateTotalCost());
        }
    }
}
