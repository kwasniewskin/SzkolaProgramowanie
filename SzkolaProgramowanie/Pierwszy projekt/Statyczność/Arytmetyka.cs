using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statyczność
{
    static class Arytmetyka
    {
        public const double pi = 3.14159;
        public const double stalaEulera = 0.57721;
        public const double zlotyPodzial = 1.61803;
        public const double xyz = 9;

        /*Arytmetyka()
        {
            //pi = 3.14159;
        }*/

        public static double ObliczPoleKola(double promien)
        {
            return Math.PI * promien * promien;
        }
    }
}
