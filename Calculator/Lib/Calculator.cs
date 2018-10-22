using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Calculator
    {
        static bool IsNumberDecrease(int number)
        {
            int n = number, numCount = (int)Math.Log10(number);
            while (n > 0 && numCount > 0)
            {
                int a = n / (int)Math.Pow(10, numCount);
                int temp = n % (int)Math.Pow(10, numCount);
                int b = temp / (int)Math.Pow(10, numCount - 1);
                if (a <= b) return false;
                n %= (int)Math.Pow(10, numCount);
                numCount--;
            }
            return true;
        }
    }
}
