using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Helpers
{
    public class Operations
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public OperationType Type { get; set; }        
    }

    public enum OperationType
    {
        OnePosOperation = 1,
        TwoPosOperation
    }

    public enum OperationsEnum
    {
        OddDigitSum = 1,
        GetSimpleMultCount,
        EvenDigitsMult,
        IsPerfect,
        IsSymtricNumber,
        IsNumberPrime,
        IsNumberDecrease,
        Factorial,
        BiggestCommonDiviser,
        SmallestCommonMultiplier,
        ArithmeticMean,
        GeometricMean        
    }
}
