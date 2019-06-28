using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ex9
    {
        // 9. Պարզել, արդյոք, տրված թիվը սիմետրիկ է։
        static bool IsSymmetrical(int n)
        {
            string str = n.ToString(); // 123322
            int len = str.Length;
            bool b = true;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - i])
                    b = false;
                    break;
            }
            return b;
        }
    }
}
