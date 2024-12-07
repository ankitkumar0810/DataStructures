using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class FibMemo
    {
        int[] F = new int[10];
        public FibMemo()
        {
            for (int i = 0; i < F.Length; i++)
            {
                F[i] = -1;
            }
        }
        
        public int Memo(int n)
        {
            if(n <= 1)
            {
                F[n] = n;
                return F[n];
            }
            else
            {
                if (F[n - 1] == -1)
                    F[n - 1] = Memo(n - 1);
                if (F[n - 2] == -1)
                    F[n - 2] = Memo(n - 2);
                F[n] = F[n - 1] + F[n - 2];
                return F[n];
            }
        }
        
    }
}
