using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Example1
    {
        public void fun1(int n)
        {
            if(n > 0)
            {
                Console.WriteLine(n);
                fun1(n - 1);
            }
        }
    }
}
