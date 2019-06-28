using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex13
    {
        public static int SumDigits(int number)
        {
            if (number == 0) return 0;

            if (number % 10 > 4 && number % 2 != 0)
            {
                return (number % 10) + SumDigits(number / 10);
            }
            else
            {
                return SumDigits(number / 10);
            }
        }

        public static void Sum(int n)
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
