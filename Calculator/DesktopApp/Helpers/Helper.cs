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

        public static object Caller(String myClass, String myMethod, string[] setParams)
        {
            // Get a type from the string 
            Type type = GetTypeByName(myClass);
            // Create an instance of that type
            Object obj = Activator.CreateInstance(type);
            // Retrieve the method you are looking for
            MethodInfo methodInfo = type.GetMethod(myMethod);
            // Invoke the method on the instance we created above
            //methodInfo.Invoke(obj, null);

            //Type Mytype = Type.GetType("parminfo");
            //MethodBase Mymethodbase = Mytype.GetMethod("mymethod");

            //https://stackoverflow.com/questions/972636/casting-a-variable-using-a-type-variable
            //https://www.google.am/search?rlz=1C1GCEU_enAM819AM819&ei=geTSW5a4B42QmgWo2JZ4&q=convert+variable+to+type+c%23+dynamically&oq=convert+variable+to+type+c%23+dynam&gs_l=psy-ab.3.0.33i22i29i30k1l4.185940.204910.0.205867.39.30.2.7.8.0.191.3636.0j25.25.0....0...1c.1.64.psy-ab..5.34.3693...0j0i67k1j0i22i30k1.0.-6XG4MBfpgg

            ParameterInfo[] paramsTypes = methodInfo.GetParameters();

            //foreach (var item in setParams)
            //{
            //    var filterType = typeof(Filters);
            //    var method = filterType.GetMethod(filter, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Static);
            //    if (method != null)
            //    {
            //        var parameters = method.GetParameters();
            //        Type paramType = parameters[0].ParameterType;
            //        value = Convert.ChangeType(method.Invoke(null, new[] { value }), paramType);
            //    }
            //}

            object returnValue = 1; //isTwoPosOperation ? Convert.ToInt32(methodInfo.Invoke(obj, new object[] { param1, param2 })) : Convert.ToInt32(methodInfo.Invoke(obj, new object[] { param1 }));

            return returnValue;
        }

        public static Type GetTypeByName(string classFullName)
        {
            Type returnVal = null;

            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] assemblyTypes = a.GetTypes();
                for (int j = 0; j < assemblyTypes.Length; j++)
                {
                    if (assemblyTypes[j].FullName == classFullName)
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


////Assembly assembly = Assembly.Load("System");
////Type typeToExecute = assembly.GetTypes()[0];
//// Get a type from the string 
////Type type1 = Type.GetType("System.Convert");
//// Create an instance of that type
//Type type1 = GetTypeByName("System.Convert");
//Object obj1 = Activator.CreateInstance(type1);
//// Retrieve the method you are looking for
//string myMethod1 = "To" + paramsTypes[i].GetType().ToString();
//MethodInfo methodInfo1 = type.GetMethod(myMethod1);