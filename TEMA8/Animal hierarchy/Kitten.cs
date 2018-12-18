using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Kitten:Cat
    {
        public Kitten( int age, string name, int sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = "female";
            

        }
    }
}
