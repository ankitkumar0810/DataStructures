using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class TowerOfHanoi
    {
        public void TOH(int n, char A, char B, char C)
        {
            if(n > 0)
            {
                TOH(n - 1, A, C, B);
                Console.WriteLine($"Move disk from {A} to {B} using {C}");
                TOH(n - 1, B, A, C);
            }
        }
    }
}
