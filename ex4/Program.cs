using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4.Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var listacarti = new List<Book>();

            listacarti.Add(new Book("Origini", "Dan Brown", 34.99));

            listacarti.Add(new Book("Dupa ce te-am pierdut", "Jojo Moyes", 19.99));

            listacarti.Add(new Book("Fiica negustorului de matase", "Dinah Jefferies", 27.99));

            listacarti.Add(new Book("Fluturi", "Irina Binder",27.5));

            listacarti.Add(new Book("Testamentul lui Abdraham", "Igor Bergler", 38.5));

            int nrcarte = 0;
            foreach (var element in listacarti)
            {
                if (nrcarte == 0 || nrcarte == 4)
                {
                    element.Price = element.Price * 1.5;


                    element.Title = element.Title.ToUpper();


                    Console.WriteLine(element.Print());
                }

                else
                {




                    Console.WriteLine(element.Print());

                }
                nrcarte++;
            }
            Console.ReadKey();

        }
    }
    
}
