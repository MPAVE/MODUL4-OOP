using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_hierarchy
{
    class Tomcat:Cat,  ISound

    { 
        public Tomcat(int age,string name, int sex)
        {
            
            this.Age = age;
            this.Name = name;
            this.Sex = "male";
        
        }
    }
}
