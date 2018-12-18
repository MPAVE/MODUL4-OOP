using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat(4, "Pisica",  "female");
            cat1.Print();
            var d1 = new Dog(3,"labrador", "male");
            d1.Print();
        }
    }
}
