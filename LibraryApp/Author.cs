using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPP
{
    class Author
    {
   //Name: string
   //Email: string (validate email)



        public Author(string name, string email)
        {
            Name = name;
            
            if (email.Contains("@gmail.com"))
            {
                this.Email = email;
            }
            else
            {
                Console.WriteLine("email nevalid");
                this.Email = " ";
            }
            
        }
        //public string get()
        //{
        //    return Name;
        //}
        //public void set(string name)
        //{
        //    Name = name;
        //}

        public string Name { get; set; }
        public string Email { get; set; }
        public void Print()
        {
            Console.WriteLine($"autorul: {Name} are email: {Email}");
        }
    }
}
