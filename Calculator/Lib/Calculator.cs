﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      
      public bool GetSymtricNumber (ulong a)
      {
            string N = Convert.ToString(a);
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] != N[N.Length - 1])
                    return false;
            }
            return true;
 
      }

    }
}
