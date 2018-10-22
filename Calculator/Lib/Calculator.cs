using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Calculator
    {
      
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
