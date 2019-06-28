using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex8
    {
        static bool SimpleNum(int n)
        {
            int Qnt = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Qnt += 1;
                    
            }
            return Qnt == 2;
        }
    }
}
