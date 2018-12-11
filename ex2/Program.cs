using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.profesor_student_si_curs
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor p1 = new Profesor
            {
                Name = "Ionescu",
                Faculty = "Info",
                Specialization = "Info"
            };
            Student s1 = new Student
            {
                Name = "Ion",
                Faculty = "feaa",
                Year = 3,

            };
            Student s2 = new Student
            {
                Name = "George",
                Faculty = "Info",
                Year = 3,

            };
            var Listatudenti = new List<Student>();
            Listatudenti.Add(s2);
            Listatudenti.Add(s1);



            Curs c1 = new Curs("info", p1, 2, Listatudenti);

         

            var str = p1.Print();

            var str2 = s1.Print();
            var str3 = c1.Print();
          

            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            foreach (var element in Listatudenti)
            {
                Console.WriteLine(element.Name);
            }
            Console.ReadLine();
        }
    }
}
