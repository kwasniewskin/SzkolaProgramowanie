using System;
using System.Collections.Generic;
using System.Text;

namespace Baza_danych___wzorzec.Model
{
    class Adress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public List<Person> Presons { get; set; }
    }
}
