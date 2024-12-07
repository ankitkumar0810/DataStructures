using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Sum
    {
        public int sum(int n)
        {
            if(n == 0) return 0;
            return sum(n - 1) + n;
        }
    }
}
