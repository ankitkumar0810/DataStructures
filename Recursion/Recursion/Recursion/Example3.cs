using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Example3
    {
        public int fun(int n)
        {
            if (n > 0)
                return fun(n - 1) + n;
            return 0;
        }
    }
}
