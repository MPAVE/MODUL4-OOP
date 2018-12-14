using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPP
{
    class Manager
    {
        public static void ManagerLibrarie()
        {
            Author author1 = new Author("William Gibson", "WILL.GB@gmail.com");
            Author author2 = new Author("Gustave Flaubert", "gus@gmail.com");
            Author author3 = new Author("Harper Lee", "harper@gmail.com");

            Book book1 = new Book((decimal)10, "SF");
            book1.AddAuthor(author1);
            Book book2 = new Book((decimal)29.99, "drama");
            book2.AddAuthor(author2);

            book2.AddAuthor(author3);

            Library library1 = new Library("MIHAI EMINESCU");
            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.RemoveBook(book1);

            library1.Print();


        }
           
    }
}
