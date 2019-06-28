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
            for(int i=0; i<n;i++)
            {
                int mul = 1;
                n%=10;
               if (n % 2 == 0 && n < 7)
                    return mul *= n;
                    n /= 10;
            }
            return 1;
        }
    }
}
