using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Calculator
    {
        public int GetSimpleMultCount(int a)
        {
            int[] mem = new int[500];
            int count = 0, i = 2;
            while (a > 0)
            {
                if (a % i == 0 && !mem.Contains(i))
                {
                    mem[count] = i;
                    count++;
                }
                while(a % i == 0)
                    a /= i;

                i++;
            }
            return count;
        }

    }
}
