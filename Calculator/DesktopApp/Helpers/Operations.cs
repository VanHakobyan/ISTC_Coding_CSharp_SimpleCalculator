using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Helpers
{
    public class Operations
    {
        public string Name{ get; set; }
        public string Description { get; set; }
        public OperationType Type { get; set; }
        //OddDigitSum = 0,
        //GetSimpleMultCount,
        //EvenDigitsMult,
        //IsPerfect,
        //IsSymtricNumber,
        //IsNumberPrime,
        //IsNumberDecrease,
        //Factorial,
        //IsFactorialNew,
        //BiggestCommonDiviser,
        //GeometricMean,
        //SmallestCommonMultiplier
    }

    public enum OperationType
    {
        OnePosOperation = 1,
        TwoPosOperation
    }
}
