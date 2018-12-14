using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Blat Italian = Blat.Italian;
            Blat Regular = Blat.Regular;
            //PizzaBase b1 = new PizzaBase(Italian, 10);

            PizzaBase b1 = new PizzaBase(Regular, 10);

            PizzaTopping top1 = new PizzaTopping("BUfallo Mozarella");
            top1.Cost = 2.5;

            PizzaTopping top2 = new PizzaTopping("Salami");
            top2.Cost = 4;
            top2.Name = top2.Name.ToUpper();

            PizzaTopping top3 = new PizzaTopping("Tomatoes");
            top3.Cost = 2;

            Pizza P1 = new Pizza(b1);
            P1.Name = "QuatroStagioni";
            P1.AddTopping(top1);
            P1.AddTopping(top2);
            P1.Print();

            Console.ReadLine();


        }
    }
}
