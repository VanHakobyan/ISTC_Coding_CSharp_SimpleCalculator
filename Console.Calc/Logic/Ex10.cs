using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex10
    {

        public static int QntS(uint n)
        {
            int qnt = 0;
            int simpQnt = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    qnt = 0;
                for (int j = 1; j <= i; j++)
                    {
                        
                        if (i % j == 0)
                            qnt += 1;
                    }
                if (qnt == 2)
                    simpQnt += 1;
            }
            return simpQnt;
        }
    }
}
