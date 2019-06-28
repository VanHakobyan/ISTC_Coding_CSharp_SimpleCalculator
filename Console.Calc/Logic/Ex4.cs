using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex4
    {
        //Գրել մեթոդ, որը հաշվում է 2 թվերի ամենափոքր ընհանուր բազմապատիկը:
    
       public static void minBazm(int a, int b)
    {
        for (int i = Math.Min(a,b); i<=a*b;i++)
        {
            
            if(i%a==0 && i%b==0)
            {
                    return i;
            }

        }

    }
        
    }

   
}
