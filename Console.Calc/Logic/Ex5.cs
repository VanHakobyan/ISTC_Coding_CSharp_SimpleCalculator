using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex5
    { 


        private static int FactNumber(int n)
        {

            if (n == 1) return 1;
            return n * FactNumber(n - 1);

        }

        public static bool Comparis(int a)
        {            
            for (int i = 1; i <= a; i++)
            {
                if (a == FactNumber(i))
                    return true;                
            }
            return false;
        }
        
    }
}