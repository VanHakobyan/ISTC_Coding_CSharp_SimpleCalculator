using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Calculator
    {
        public bool IsPerfect (int number)
        {
            int divisorSum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    divisorSum += i;
                }
            }
            if (divisorSum == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
