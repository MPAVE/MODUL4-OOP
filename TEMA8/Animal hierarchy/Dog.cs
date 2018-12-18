using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Dog : Animals, ISound
    {
        public Dog(int age, string name, string sex)
        {

            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
        public string Sound()
        {
            return "ham";

        }
        public void Print()
        {
            Console.WriteLine($"Dog {this.Name} ({this.Sex}), age{this.Age}, sound{this.Sound()}");
        }
        public static decimal GetAverageAgeDogs()
        {

        }
    }
}
