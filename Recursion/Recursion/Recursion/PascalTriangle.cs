using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class PascalTriangle
    {
        public int fact(int n)
        {
            int f = 1;
            for(int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }
        public int C(int n, int r)
        {
            if (r == 0 || n == r)
                return 1;
            else
                return C(n - 1, r - 1) + C(n - 1, r);
        }
        public void PrintPascalTriangle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int k = 0; k < n - i; k++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(C(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
