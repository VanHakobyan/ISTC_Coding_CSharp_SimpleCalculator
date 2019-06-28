using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex12
    {
        //12.	Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։
        public static int SmallestOddNumber(int n)
        {
            List<int> array = new List<int>();
            
            while (n>0)
            {
                
                int digit = n % 10;
                if (digit %2 != 0)
                {
                    array.Add(digit);
                }
                n /= 10;
            }
            return array.Min();
        }
    }
}
