using DesktopApp.Helpers;
using Lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
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
        //ObservableCollection<int> Functions;
        List<string> twoPositionalFunctions;
        List<string> onePositionalFunctions;

        Calculator _calculator;

        public MainWindow()
        {
            InitializeComponent();

            twoPositionalFunctions = new List<string>();
            onePositionalFunctions = new List<string>();

            _calculator = new Calculator();

            twoPositionalFunctions.Add("Biggest Common Diviser");
            twoPositionalFunctions.Add("Geometric Mean");
            twoPositionalFunctions.Add("Smallest Common Multiplier");

            onePositionalFunctions.Add("Get Simple Multy Count");


            Combo.ItemsSource = twoPositionalFunctions;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double num1 = Convert.ToDouble(MyTextBox.Text);
            double num2 = Convert.ToDouble(MyTextBox1.Text);

            var comboSelectedOperation = Combo.SelectedItem.ToString();

            switch (comboSelectedOperation)
            {
                case "Biggest Common Diviser":
                    label.Content = _calculator.BiggestCommonDiviser((int)num1, (int)num2);
                    break;
                case "Geometric Mean":
                    label.Content = _calculator.GeometricMean((int)num1, (int)num2);
                    break;
                case "Smallest Common Multiplier":
                    label.Content = _calculator.SmallestCommonMultiplier((int)num1, (int)num2);
                    break;
                default:
                    break;
            }
        }
    }
}
