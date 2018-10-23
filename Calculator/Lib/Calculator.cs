using System;
using System.Linq;

namespace Lib
{
    public class Calculator
    {
        #region "OnePositionalOperations"

        public int OddDigitSum(int num)
        {
            int N = Convert.ToString(num).Length;
            int[] number = new int[N];
            int sum = 0;
            bool flag = false;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = num / (int)Math.Pow(10, i) % 10;
                if (number[i] % 2 != 0 && number[i] > 4)
                {
                    sum += number[i];
                    flag = true;
                }

            }
            return (flag) ? sum : -1;
        }
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
                    while (a % i == 0)
                        a /= i;
                }
                i++;
            }
            return count;
        }
        /// <summary>
        /// 14.	Հաշվել տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int EvenDigitsMult(int num)
        {
            int mult = 1;
            num = Math.Abs(num);
            while (num > 0)
            {
                int t = num % 10;
                mult = (num % 2 == 0 && t > 0 && t < 7) ? mult * t : mult;
                num /= 10;
            }
            return (mult > 1) ? mult : -1;
        }
        public bool IsPerfect(int number)
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
        public bool IsNumberPrime(int n)
        {
            if (n % 2 == 0) return false;
            for (int i = 3; i * i < n; i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }
        public bool IsSymtricNumber(ulong a)
        {
            string N = Convert.ToString(a);
            for (int i = 0; i < N.Length / 2; i++)
                if (N[i] != N[N.Length - i - 1])
                    return false;
            return true;
        }
        public bool IsNumberDecrease(int number)
        {
            string numstr = number.ToString();
            for (int i = 0; i < numstr.Length - 1; i++)
                if (numstr[i] <= numstr[i + 1])
                    return false;
            return true;
        }
        public int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
        public bool IsFactorialNew(int number)
        {
            bool flag = true;
            for (int i = 1; i < number; i++)
            {
                if (Factorial(i) == number)
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

        #endregion "OnePositionalOperations"

        #region "TwoPositionalOperations"

        public int BiggestCommonDiviser(int a, int b)
        {
            int min = a < b ? a : b;
            int diviser = 1;
            if (a % min == 0 && b % min == 0) return min;

            for (int i = min / 2; i > 1; i--)
                if (a % i == 0 && b % i == 0)
                {
                    diviser = i;
                    break;
                }

            return diviser;

        }
        public double GeometricMean(double a, double b)
        {
            double GeomMean = 0;
            if (a != 0 && b != 0)
            {
                GeomMean = (a * b) / 2;
            }
            return GeomMean;

        }
        public double GeometricMean(int n, int b)
        {
            double c = (n + b) / 2;
            return c;
        }
        public int SmallestCommonMultiplier(int a, int b)
        {
            return a * b / BiggestCommonDiviser(a, b);
        }

        #endregion "TwoPositionalOperations"       
    }
}


/* public bool IsFactorial (int number)
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
        */
