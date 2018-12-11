using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.autor_si_carte
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author {
                Name = "Popescu",
                Email = "popescu@gmail.com",
                Country = "Romania" };
            Book b1 = new Book
            {
                Name = "Amintiri din copilarie",
                Author = "Ion Creanga",
                Year = 2009,
                Price = 10
            };
           
            var str = a1.Print();
            var str2 = b1.Print();


            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.ReadLine();

        }
    }
}
