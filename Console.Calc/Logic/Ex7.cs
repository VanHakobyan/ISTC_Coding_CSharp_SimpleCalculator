using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex7
    {
        // 7.	Պարզել, արդյոք, տրված թիվը կատարյալ է։
        public static bool CheckTheNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
                
            }
            return n == sum;
            
        }

        

    }
}
