using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.profesor_student_si_curs
{
    class Curs
    {
        public Curs(string name, Profesor Prof, int year, List<Student> listastudenti)
        {
            Name = name;
            Profesor = Profesor;
            Year = year;
            Listastudenti = listastudenti;
        }
        public string Name { get; set; }
        public string Profesor { get; set; }
        public int Year { get; set; }
        public List<Student> Listastudenti { get; set; }
        
        public string Print()
        {
            return $"Cursul de {Name} este sustinut de profesorul {Profesor} in anul {Year} si studentii sunt: ";
        }
    }
}
