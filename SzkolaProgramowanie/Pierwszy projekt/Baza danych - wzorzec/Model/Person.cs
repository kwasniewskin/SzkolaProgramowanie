using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Baza_danych___wzorzec.Model
{
    class Person
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public int Age { get; set; }

        public int AdressId { get; set; }
        public Adress Adress { get; set; }
    }
}
