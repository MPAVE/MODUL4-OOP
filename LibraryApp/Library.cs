using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPP
{
    class Library
    {
        //Name: string
        //Books: List<Book>
        //AddBook(Book) => If the library already has the book, do nothing
        //RemoveBook(bookName)

        public Library(string nume)
        {
            Name = nume;
            Books = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RemoveBook(Book bookname)
        {
            Books.Remove(bookname);
        }
        //public void UpdateBook(Book bookname)
        //{
        //    foreach (var book in Books)
        //    {
        //        if (book.Authors.Equals("LALA"))
        //        {
        //            book.Authors = bookname.Authors;
        //        }
        //    }
        //}

        public void Print()
        {
            Console.WriteLine($"libraria {Name} are {Books.Count} cartile:");
            foreach (var book in Books)

            {
                book.Print();
            }
        }

    }
}
