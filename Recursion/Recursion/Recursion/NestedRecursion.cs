using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class NestedRecursion
    {
        public int fun(int n)
        {
            if(n > 100)
            {
                return n - 10;
            }
            else
            {
                return fun(fun(n + 11));
            }
        }
    }
}
