using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.autor_si_carte
{
    class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public string Print()
        {
            return $"autorul cu numele {Name} are emailul {Email} si locuieste in {Country}.";
        }
    }
}
