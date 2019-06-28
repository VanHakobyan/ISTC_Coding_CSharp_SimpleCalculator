using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex11
    {
        public static bool DecliningSequence(int a)
        {
            while (a != 0)
            {
                int b = a % 10;
                a = a / 10;

                if (b < a % 10)
                {
                    return true;
                }
               
            }
            return false;

        }





    }
}

