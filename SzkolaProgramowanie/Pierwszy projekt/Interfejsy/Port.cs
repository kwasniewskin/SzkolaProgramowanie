using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    class Port : IPort
    {
        protected string nazwa;

        public Port(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public void Informacja()
        {
            Console.WriteLine("Jestem obiektem o nazwie " + nazwa);
        }

        public virtual int PobierzDana()
        {
            throw new NotImplementedException();
        }

        public virtual void WyslijDana(int dana)
        {
            throw new NotImplementedException();
        }
    }
}
