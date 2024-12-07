using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Power
    {
        public int Exponent(int m, int n)
        {
            if (n == 0)
                return 1;
            else if(n % 2 == 0)
                return Exponent(m * m, n / 2);
            else
                return m * Exponent(m * m, (n - 1) / 2);
        }
    }
}
