using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class IndirectRecursion
    {
        public void funA(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                funB(n - 1);
            }
        }
        public void funB(int n)
        {
            if(n > 1)
            {
                Console.WriteLine(n);
                funA(n / 2);
            }
        }
    }
}
