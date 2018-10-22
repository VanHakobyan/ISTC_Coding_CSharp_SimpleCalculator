using System;
using System.Linq;

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
        public int EvenDigitsMult(int num)
        {
            int mult = 1;
            num = Math.Abs(num);

            while (num > 0)
            {
                mult = (num % 2 == 0 && num % 10 > 0 && num % 10 < 7) ? mult * num % 10 : mult;
                num /= 10;
            }

            return (mult > 1)? mult : int.MinValue;
        }
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
