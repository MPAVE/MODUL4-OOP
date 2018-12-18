using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentd_and_workers
{
    class Program
    {
        public static List<Student> ListStudents()
        {
            Student s1 = new Student("Mihai", "Pavel", 8.75);
            Student s2 = new Student("Gogu", "Alexandru",8);
            Student s3 = new Student("Ciprian", "Axinte", 8.20);
            Student s4 = new Student("Mara", "Popovici", 9);
            Student s5 = new Student("Anca", "Ciurciun", 9.75);
            Student s6 = new Student("Cristian", "Sinescu", 9.5);
            Student s7 = new Student("Ionut", "Popa", 8.5);
            Student s8 = new Student("Tudor", "Ciobanu", 9.25);
            Student s9 = new Student("Andrei", "Lupascu", 7.25);
            Student s10 = new Student("Vlad", "Ionescu", 10);
            var list1 = new List<Student>();
            list1.Add(s1);
            list1.Add(s2);
            list1.Add(s3);
            list1.Add(s4);
            list1.Add(s5);
            list1.Add(s6);
            list1.Add(s7);
            list1.Add(s8);
            list1.Add(s8);
            list1.Add(s10);
            foreach (var student in list1.OrderBy          ))
            {
                
            }
            Console.WriteLine();

            return list1;
        }

        public static List<Worker> ListWorkers()
        {
            Worker w1 = new Worker("Marian", "Adascalite", 250, 7);
            Worker w2 = new Worker("Marian", "Adascalite", 250, 7);
            Worker w3 = new Worker("Marian", "Adascalite", 250, 7);
            Worker w4 = new Worker("Marian", "Adascalite", 250, 7);
            Worker w5 = new Worker("Marian", "Adascalite", 250, 7);
            Worker w6 = new Worker("Marian", "Adascalite", 250, 7);
            Worker w7= new Worker("Marian", "Adascalite", 250, 7);
            Worker w8 = new Worker("Marian", "Adascalite", 250, 7);
            Worker w9 = new Worker("Marian", "Adascalite", 250, 7);
            Worker w10 = new Worker("Marian", "Adascalite", 250, 7);
            var list2 = new List<Worker>();
            list2.Add(w1);
            list2.Add(w2);
            list2.Add(w3);
            list2.Add(w4);
            list2.Add(w5);
            list2.Add(w6);
            list2.Add(w7);
            list2.Add(w8);
            list2.Add(w9);
            list2.Add(w10);
            foreach (var Worker in list2.OrderByDescending())
            {

            }
            Console.ReadLine();
            return list2;
        }
    
        static void Main(string[] args)
        {
            var listastudent = ListStudents();
            var listaworker = ListWorkers();
        }
       
    }
}
