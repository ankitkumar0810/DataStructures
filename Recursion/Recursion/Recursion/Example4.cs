using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Example4
    {
        static int x = 0;
        public int fun(int n)
        {
            if (n > 0)
            {
                x++;
                return fun(n - 1) + x;
            }
            return 0;
        }
    }
}
