using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef9
{
    internal class Vak
    {
        public string Naam { get; set; } = "";
        public Leraar Leraar { get; set; }
        public List<Student> Studenten { get; set; }

        public Vak(string naam, Leraar leraar)
        {
            Naam = naam;
            Leraar = leraar;
            Studenten = new List<Student>();
        }
    }
}
