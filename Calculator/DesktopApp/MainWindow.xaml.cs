using DesktopApp.Helpers;
using Lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region "Private fields"
        private List<Operations> TwoPosOperationsList { get; set; }
        private List<Operations> OnePosOperationsList { get; set; }
        #endregion "Private fields"

        #region "ctor"
        public MainWindow()
        {
            InitializeComponent();
            //this is now local, some day will come from db (data base)
            GetOperationsInfo();

            //Bind Two positional operations (to see in dropdown)
            TwoPosOperations.ItemsSource = TwoPosOperationsList;
            TwoPosOperations.SelectedValuePath = "Id";
            TwoPosOperations.DisplayMemberPath = "Name";

            //Bind One positional operations (to see in dropdown)
            OnePosOperations.ItemsSource = OnePosOperationsList;
            OnePosOperations.SelectedValuePath = "Id";
            OnePosOperations.DisplayMemberPath = "Name";

        }
        #endregion "ctor"

        #region "Helpers"
        
        //Prevent user add text in inputs
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private static object Caller(String myclass, String mymethod, double param1, double param2, bool isTwoPosOperation = false)
        {
            // Get a type from the string 
            Type type = GetTypeByName(myclass);
            // Create an instance of that type
            Object obj = Activator.CreateInstance(type);
            // Retrieve the method you are looking for
            MethodInfo methodInfo = type.GetMethod(mymethod);
            // Invoke the method on the instance we created above
            //methodInfo.Invoke(obj, null);
            object returnValue = isTwoPosOperation ? Convert.ToInt32(methodInfo.Invoke(obj, new object[] { param1, param2 })) : Convert.ToInt32(methodInfo.Invoke(obj, new object[] { param1 }));

            return returnValue;
        }

        private static Type GetTypeByName(string className)
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

        //Just manually add info
        private void GetOperationsInfo()
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

        #endregion "Helpers"

        #region "Calculations"

        private void TwoPosCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (twoPosFrstNum.Text != "" && twoPosScndNum.Text != "" &&
                TwoPosOperations.SelectedItem != null)
            {
                var frstNum = Convert.ToDouble(twoPosFrstNum.Text);
                var scndNum = Convert.ToDouble(twoPosScndNum.Text);

                var selectedItem = (Operations)TwoPosOperations.SelectedItem;
                var result = Caller("Calculator", ((OperationsEnum)(selectedItem.Id)).ToString(), frstNum, scndNum, true);

                TwoPosResult.Text = result.ToString();
            }
            else
                MessageBox.Show("Խնդրում ենք լրացնել դաշտերը․․․");
        }
        private void OnePosCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (onePosNum.Text != "" && OnePosOperations.SelectedItem != null)
            {
                var num = Convert.ToDouble(onePosNum.Text);

                var selectedItem = (Operations)OnePosOperations.SelectedItem;
                var result = Caller("Calculator", ((OperationsEnum)(selectedItem.Id)).ToString(), num, 0);

                OnePosResult.Text = result.ToString();
            }
            else
                MessageBox.Show("Խնդրում ենք լրացնել դաշտերը․․․");
        }

        #endregion "Calculations"
    }
}