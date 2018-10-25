using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DesktopApp.Helpers
{
    public class Helper
    {
        #region "Public fields"
        public List<Operations> TwoPosOperationsList { get; set; }
        public List<Operations> OnePosOperationsList { get; set; }
        #endregion

        #region "ctor"

        public Helper()
        {
            TwoPosOperationsList = new List<Operations>
            {
                new Operations
                {
                    Id = 9,
                    Name = "Ամենամեծ ընհանուր բաժանարար",
                    Description = "Հաշվում է 2 թվերի ամենամեծ ընհանուր բաժանարարը:",
                    Type = OperationType.TwoPosOperation
                },
                new Operations
                {
                    Id = 10,
                    Name = "Ամենափոքր ընհանուր բազմապատիկը",
                    Description = "Հաշվում է 2 թվերի ամենափոքր ընհանուր բազմապատիկը։",
                    Type = OperationType.TwoPosOperation
                },
                new Operations
                {
                    Id = 11,
                    Name = "Միջին թվաբանական",
                    Description = "Հաշվում է 2 թվերի միջին թվաբանականը։",
                    Type = OperationType.TwoPosOperation
                },
                new Operations
                {
                    Id = 12,
                    Name = "Միջին երկրաչափականը",
                    Description = "Հաշվում է 2 թվերի միջին երկրաչափականը։",
                    Type = OperationType.TwoPosOperation
                }
            };

            OnePosOperationsList = new List<Operations>
            {
                new Operations
                {
                    Id = 1,
                    Name = "4-ից մեծ կենտ թվանշանների գումար",
                    Description = "Հաշվում է տրված թվի 4-ից մեծ կենտ թվանշանների գումարը։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Id = 2,
                    Name = "Պարզ արտադրիչների քանակ",
                    Description = "Հաշվում է տրված բնական թվի պարզ արտադրիչների քանակը",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Id = 3,
                    Name = "7-ից փոքր զույգ թվանշանների արտադրյալ",
                    Description = "Հաշվում է տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Id = 4,
                    Name = "Ստուգել կատարյալ լինելը",
                    Description = "Պարզում է, արդյոք, տրված թիվը կատարյալ է։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Id = 5,
                    Name = "Ստուգել սիմետրիկ լինելը",
                    Description = "Պարզում է, արդյոք, տրված թիվը սիմետրիկ է։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Id = 6,
                    Name = "Ստուգել պարզ լինելը",
                    Description = "Ստուգում է, արդյոք, տրված թիվը պարզ է։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Id = 7,
                    Name = "Ստուգել նվազող հաջ․ լինելը",
                    Description = "Ստուգում է, տրված թվի թվանշանները ձախից աջ դիտարկելիս կազմում են, արդյոք, նվազող հաջորդականություն",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Id = 8,
                    Name = "Պարզել, որևէ թվի ֆակտորիալ լինելը",
                    Description = "Պարզում է, հանդիսանում է, արդյոք, տրված թիվը որևէ թվի ֆակտորիալ։",
                    Type = OperationType.OnePosOperation
                },
            };
        }

        #endregion

        #region "Enums"

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

        #endregion "Enums"

        #region "Validation"

        internal bool NumberValidation(string text)
        {
            Regex regex = new Regex("[^0-9]+");

            return regex.IsMatch(text);
        }

        #endregion "Validation"

        #region "Public Methods"      

        public static object Caller(String myclass, String mymethod, string param1, string param2, bool isTwoPosOperation = false)
        {
            // Get a type from the string 
            Type type = GetTypeByName(myclass);
            // Create an instance of that type
            Object obj = Activator.CreateInstance(type);
            // Retrieve the method you are looking for
            MethodInfo methodInfo = type.GetMethod(mymethod);
            // Invoke the method on the instance we created above
            //methodInfo.Invoke(obj, null);

            //Type Mytype = Type.GetType("parminfo");
            //MethodBase Mymethodbase = Mytype.GetMethod("mymethod");
            ParameterInfo[] myParams = methodInfo.GetParameters();



            object returnValue = isTwoPosOperation ? Convert.ToInt32(methodInfo.Invoke(obj, new object[] { param1, param2 })) : Convert.ToInt32(methodInfo.Invoke(obj, new object[] { param1 }));

            return returnValue;
        }

        public static Type GetTypeByName(string className)
        {
            Type returnVal = null;

            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] assemblyTypes = a.GetTypes();
                for (int j = 0; j < assemblyTypes.Length; j++)
                {
                    if (assemblyTypes[j].Name == className)
                    {
                        returnVal = (assemblyTypes[j]);
                    }
                }
            }

            return returnVal;
        }

        #endregion
    }
}
