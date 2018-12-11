using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.profesor_student_si_curs
{
    class Student
    {
        public string Name { get; set; }

        public string Faculty { get; set; }

        public int Year { get; set; }

      
      
        public string Print()
        {
           
            return $"Studentul cu numele {Name} este la facultatea de {Faculty} in anul {Year}.";
        }
    }
}
