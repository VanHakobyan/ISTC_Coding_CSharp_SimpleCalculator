using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex3
    {
        //3.Գրել մեթոդ, որը հաշվում է 2 թվերի ամենամեծ ընհանուր բաժանարարը:
       public static int MaxBaj(int a, int b)
       {

            for (int  i = Math.Min(a,b);i > 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return i;
                }
               
                  
            }
            return 1;
       }
    }
    
}
