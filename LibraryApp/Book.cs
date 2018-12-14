using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPP
{
    class Book
    {
        // Price: decimal
        // Genre: string (Drama, Action, Mystery, Romance, SF, ...) 
        //Authors: List<Author>
        //AddAuthor(Author) => If the book already has the author, do nothing
        //GetPrice() - If the genre is: drama => discount 10%, SF=> discount 15%

        public Book ( decimal price, string genre)
        {
            Price = price;
            Genre = genre;
            Authors = new List<Author>();
        }

        public decimal Price { get; set; }
        public string Genre { get; set; }
        public List<Author> Authors { get; set; }
        public void AddAuthor (Author author)
        {
            Authors.Add(author);
        }

        public decimal GetPrice()
        {
            if (Genre.ToLower()== "drama")
            {
                return Price - (decimal)0.10 * Price;
            }
            else
                if (Genre.ToLower()=="SF")
            {
                return Price - (decimal)0.15 * Price;
            }
            else
            {
                return Price;
            }
        }

        public void Print()
        {
            Console.WriteLine($" genul:{Genre}, pretul: {Price} ");
            foreach (var author in Authors)
            {
                author.Print();
            }
        }

    }
}
