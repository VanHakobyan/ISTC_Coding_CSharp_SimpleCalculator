using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex5
    { 


        public static int FactNumber(int n)
        {

            if (n == 1) return 1;
            return n * FactNumber(n - 1);

        }
        public static bool comparis(int a)
        {
            int n;
            for (int i = 1; i <= FactNumber(n); i++)
            {
                if (a == FactNumber(n))
                    return true;
                else
                    return false;
            }
            return false;
        }
        
    }
}