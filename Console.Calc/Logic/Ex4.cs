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

        public static int MinMultiple(int n1, int n2)
        {
            int n3 = n1;
            while (n3 % n2 != 0 || n3 %  n1 != 0)
            {
                n3++;
            }
            return n3;   
        }
        //Գրել մեթոդ, որը հաշվում է 2 թվերի ամենափոքր ընհանուր բազմապատիկը:

        public static int MinBazm(int a, int b)
        {
            for (int i = Math.Min(a, b); i <= a * b; i++)
            {

                if (i % a == 0 && i % b == 0)
                {
                    return i;
                }
                
            }
               return a * b;
        }

    }


}
