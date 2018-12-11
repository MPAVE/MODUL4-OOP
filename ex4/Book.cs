using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4.Book
{
    class Book
    {
        public Book(string title, string author, double price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public string Author { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public string Print()
        {
            return $"Autorul cartii este {Author}, titlul este {Title} si are pretul de {Price}";
        }
    }
}

