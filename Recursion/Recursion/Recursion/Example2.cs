using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Example2
    {
        public void fun2(int n)
        {
            if (n > 0)
            {
                fun2(n - 1);
                Console.WriteLine(n);
            }
        }
    }
}
