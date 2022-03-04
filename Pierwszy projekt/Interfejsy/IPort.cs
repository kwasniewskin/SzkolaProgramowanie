using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    interface IPort
    {
        void WyslijDana(int dana);

        int PobierzDana();
    }
}
