using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c=Ex5.Comparis(6);
            //bool b = Ex7.CheckTheNumber(8);
            //Console.WriteLine(b);
            //int b = Ex4.MinBazm(2,4);
            Console.WriteLine(c);
            
            int b = Ex4.MinBazm(2,4);
            Console.WriteLine(b);

            Console.WriteLine(Ex12.SmallestOddNumber(3587));
        }
    }
}
