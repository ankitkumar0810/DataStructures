using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class LinearRecursion
    {
        public void fun(int n)
        {
            if(n > 0)
            {
                Console.WriteLine(n);
                fun(n - 1);
            }
        }
    }
}
