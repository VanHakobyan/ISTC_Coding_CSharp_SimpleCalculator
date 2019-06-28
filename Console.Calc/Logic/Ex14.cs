using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex14
    {
        //Հաշվել տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։
        public static int Mul (int n)
        {
            int mul = 1;
            for (int i = 0; i < n; i++)
            {
               int s= n % 10;
                if (s % 2 == 0 && s < 7)
                    mul *=s;
                n /= 10;
            }
            return mul;

            

        }
    }
}
