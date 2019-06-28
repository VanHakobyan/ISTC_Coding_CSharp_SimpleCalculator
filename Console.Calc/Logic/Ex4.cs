using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex4
    {
        // 4.Գրել մեթոդ, որը հաշվում է 2 թվերի ամենափոքր ընհանուր բազմապատիկը:

        public int MinMultiple(int n1, int n2)
        {

            while (n1 % n2 != 0)
            {
                n1++;
            }
            return n1;
            
        }
    }
}
