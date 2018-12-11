using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5.pizza
{
    class pizza
    {

        public pizza(string name, PizzaBase pizzaBase, List<PizzaTopping> listatopinguri)
        {
            Name = name;
            Base = pizzaBase;
            Listatopinguri = listatopinguri;
        }

        public string Name { get; set; }

        public PizzaBase Base { get; set; }

        public List<PizzaTopping> Listatopinguri
        { get; set; }

        public double Cost { get; set; }

        public void AddTopping(PizzaTopping pizzaTopping)
        {
            Listatopinguri.Add(pizzaTopping);
        }
        public string Print()
        {
            return $"Pizza {Name}";

        }

        public string CalculateTotalCost()
        {

        }
    }
}
