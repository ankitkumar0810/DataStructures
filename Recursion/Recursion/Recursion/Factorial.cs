using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Factorial
    {
        public int Fact(int n)
        {
            if (n == 0)
                return 1;
            return Fact(n - 1) * n;
        }
    }
}
