using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Cat : Animals, ISound
    {
        public Cat(int age,string name,  string sex)
        {
           
            this.Age = age;
            this.Name = name;
            this.Sex = sex;

        }
        public string Sound()
        {
            return "miau";
        }
        public void Print()
        {
            Console.WriteLine($"Cat {this.Name} ({this.Sex}), age{this.Age}, sound{this.Sound()}");
        }
        public static decimal GetAverageAgeCats()
        {

        }
    }
}
