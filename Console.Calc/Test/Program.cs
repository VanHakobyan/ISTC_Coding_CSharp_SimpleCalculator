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

            Console.WriteLine(Logic.Ex4.MinMultiple(3,7));
            Console.WriteLine(Ex9.IsSymmetrical(123454321));
            Console.WriteLine(Ex13.SumDigits(5648231));


            bool b1 = Ex7.CheckTheNumber(8);
            Console.WriteLine(b1);
            int b2 = Ex4.MinBazm(2,4);
            Console.WriteLine(b2);
            int b3 =  Ex3.MaxBaj(8,12);
            Console.WriteLine(b3);

        }
    }
}
