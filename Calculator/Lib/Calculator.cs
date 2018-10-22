using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Calculator
    {
        public int MinOddDigit(int num)
        {
            int odd = 99;
            bool flag = false;

            while (num != 0)
            {
                int digit = (int)num % 10;
                if (digit % 2 != 0 && digit < odd)
                {
                    odd = digit;
                    flag = true;

                }
                num /= 10;
            }
            return (flag) ? odd : -1;
        }
    }
}
