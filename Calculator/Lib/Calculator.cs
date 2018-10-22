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
      
      public bool IsSymtricNumber (ulong a)
      {
            string N = Convert.ToString(a);
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] != N[N.Length - i])
                    return false;
            }
            return true;
 
      }


        public int BiggestCommonDiviser(int a, int b)
        {
            int min = a < b ? a : b;
            int diviser = 1;
            if (a % min == 0 && b % min == 0) return min;

            for (int i = min / 2; i > 1; i++)
                if (a % i == 0 && b % i == 0)
                {
                    diviser = i;
                    break;
                }

            return diviser;
                                 
        }

        public double GeometricMean(double a , double b)
        {
            double GeomMean=0;
            if (a != 0 && b != 0)
            {
             GeomMean = (a * b) / 2;
            }
            return GeomMean;

        }
        public bool IsNumberPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public double GeometricMean(int n,int b)
        {
            double c = (n + b) / 2;
            return c;
        }


        public int SmallestCommonMultiplier(int a, int b)
        {
            return a * b / BiggestCommonDiviser(a, b);
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
