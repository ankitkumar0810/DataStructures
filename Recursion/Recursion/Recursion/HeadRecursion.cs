using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class HeadRecursion
    {
        public void fun(int n)
        {
            if (n > 0)
            {
                fun(n - 1);
                Console.WriteLine(n);
            }
        }
    }
}
