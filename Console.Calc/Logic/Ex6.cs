using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex6
    {
        public static bool CheckIfFib(int N)
        {
            int n = Int32.Parse(Console.ReadLine());
            int fib;
            int a = 1;
            int b = 1;

            for (; ; )
            {
                fib = a + b;

                b = a;
                a = fib;

                if (a == n)
                {
                    return true;
                }
                if (a > n)
                {
                    return false;
                    
                }
            }

        }

    }
}
