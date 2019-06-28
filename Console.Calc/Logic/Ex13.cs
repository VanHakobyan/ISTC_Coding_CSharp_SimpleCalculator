using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex13
    {
        public static int Sum(int n)
        {
            //13.	Հաշվել տրված թվի 4-ից մեծ կենտ թվանշանների գումարը։
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int s = n % 10;
                if (s % 2 != 0 && s > 4)
                   sum += s;
                n /= 10;

            }
            return sum;
        }
    }
}
