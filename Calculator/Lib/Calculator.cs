using System;

namespace Lib
{
    public class Calculator
    {
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
        public bool IsFactorial (int number)
        {
            int product = 1;
            bool flag = true;
            for (int i = 1; i < number; i++)
            {
                product *= i;
                if (product == number)
                {
                    flag = true;
                    break;
                }
                else
                {
                   flag = false;
                }
            }
            return flag ? true : false;
        }
    }
}
