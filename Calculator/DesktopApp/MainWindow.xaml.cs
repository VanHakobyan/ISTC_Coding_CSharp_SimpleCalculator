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
        public List<Operations> operations;
        public MainWindow()
        {
            InitializeComponent();
            GetOperationsInfo(); //this is now local, some day will come from db

            foreach (var op in operations.Where(w => w.Type == OperationType.TwoPosOperation))
            {
                TwoPosOperations.Items.Add(op.Name);
            }

            foreach (var op in operations.Where(w => w.Type == OperationType.OnePosOperation))
            {
                OnePosOperations.Items.Add(op.Name);
            }
        }

        private void GetOperationsInfo()
        {
            operations = new List<Operations>
            {
                new Operations
                {
                    Name = "4-ից մեծ կենտ թվանշանների գումար",
                    Description = "Հաշվում է տրված թվի 4-ից մեծ կենտ թվանշանների գումարը։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Name = "Պարզ արտադրիչների քանակ",
                    Description = "Հաշվում է տրված բնական թվի պարզ արտադրիչների քանակը",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Name = "7-ից փոքր զույգ թվանշանների արտադրյալ",
                    Description = "Հաշվում է տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Name = "Ստուգել կատարյալ լինելը",
                    Description = "Պարզում է, արդյոք, տրված թիվը կատարյալ է։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Name = "Ստուգել սիմետրիկ լինելը",
                    Description = "Պարզում է, արդյոք, տրված թիվը սիմետրիկ է։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Name = "Ստուգել պարզ լինելը",
                    Description = "Ստուգում է, արդյոք, տրված թիվը պարզ է։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Name = "Ստուգել նվազող հաջ․ լինելը",
                    Description = "Ստուգում է, տրված թվի թվանշանները ձախից աջ դիտարկելիս կազմում են, արդյոք, նվազող հաջորդականություն",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Name = "Պարզել, որևէ թվի ֆակտորիալ լինելը",
                    Description = "Պարզում է, հանդիսանում է, արդյոք, տրված թիվը որևէ թվի ֆակտորիալ։",
                    Type = OperationType.OnePosOperation
                },
                new Operations
                {
                    Name = "Ամենամեծ ընհանուր բաժանարար",
                    Description = "Հաշվում է 2 թվերի ամենամեծ ընհանուր բաժանարարը:",
                    Type = OperationType.TwoPosOperation
                },
                new Operations
                {
                    Name = "Ամենափոքր ընհանուր բազմապատիկը",
                    Description = "Հաշվում է 2 թվերի ամենափոքր ընհանուր բազմապատիկը։",
                    Type = OperationType.TwoPosOperation
                },
                new Operations
                {
                    Name = "Միջին թվաբանական",
                    Description = "Հաշվում է 2 թվերի միջին թվաբանականը։",
                    Type = OperationType.TwoPosOperation
                },
                new Operations
                {
                    Name = "Միջին երկրաչափականը",
                    Description = "Հաշվում է 2 թվերի միջին երկրաչափականը։",
                    Type = OperationType.TwoPosOperation
                }
            };

        }


        //don't let the input to be text.. only numbers
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TwoPosCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (twoPosFrstNum.Text != "" && 
                TwoPosOperations.SelectedItem != null)
            {
                switch (TwoPosOperations.SelectedItem)
                {
                    default:
                        break;
                }
            }
            else
                MessageBox.Show("Խնդրում ենք լրացնել դաշտերը․․․");
        }

        private void OnePosCalculate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

//ObservableCollection<int> Functions;
//List<string> twoPositionalFunctions;
//List<string> onePositionalFunctions;

//Calculator _calculator;
//for (int i = 0; i < 10; i++)
//{
//    Button newBtn = CreateButton(i);
//    Calc.Children.Add(newBtn);
//    newBtn.Click += new RoutedEventHandler(this.ButtonClick);
//}
//
//
//
//

//
//
//
//
//
//
//
//
//
//
//

//
//

//twoPositionalFunctions = new List<string>();
//onePositionalFunctions = new List<string>();

//_calculator = new Calculator();

//twoPositionalFunctions.Add("Biggest Common Diviser");
//twoPositionalFunctions.Add("Geometric Mean");
//twoPositionalFunctions.Add("Smallest Common Multiplier");

//onePositionalFunctions.Add("Get Simple Multy Count");


//Combo.ItemsSource = twoPositionalFunctions;

//double num1 = Convert.ToDouble(MyTextBox.Text);
//double num2 = Convert.ToDouble(MyTextBox1.Text);

//var comboSelectedOperation = Combo.SelectedItem.ToString();

//            switch (comboSelectedOperation)
//            {
//                case "Biggest Common Diviser":
//                    label.Content = _calculator.BiggestCommonDiviser((int) num1, (int) num2);
//                    break;
//                case "Geometric Mean":
//                    label.Content = _calculator.GeometricMean((int) num1, (int) num2);
//                    break;
//                case "Smallest Common Multiplier":
//                    label.Content = _calculator.SmallestCommonMultiplier((int) num1, (int) num2);
//                    break;
//                default:
//                    break;
//            }