using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.profesor_student_si_curs
{
    class Profesor
    {
        public string Name { get; set; }

        public string Faculty { get; set; }

        public string Specialization { get; set; }

        public string Print()
        {
            return $"{Name} preda la facultatea de {Faculty} ,specializarea {Specialization}.";
        }
    }
}
