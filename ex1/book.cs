using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.autor_si_carte
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; } 
        public double Price { get; set; }
         public string Print()
        {
            return $"cartea cu numele {Name} este scrisa de autorul {Author} in anul {Year} si are pretul de {Price} lei.";

        }
        
    }

}
