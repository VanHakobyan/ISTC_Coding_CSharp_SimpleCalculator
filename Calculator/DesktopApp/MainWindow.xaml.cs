using DesktopApp.Helpers;
using Lib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using static DesktopApp.Helpers.Helper;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region "Private fields"
        private Helper _helper;        
        #endregion "Private fields"

        #region "ctor"
        public MainWindow()
        {
            InitializeComponent();
            Calculator _calc = new Calculator();
            _helper = new Helper();

            //Bind Two positional operations (to see in dropdown)
            TwoPosOperations.ItemsSource = _helper.TwoPosOperationsList;
            TwoPosOperations.SelectedValuePath = "Id";
            TwoPosOperations.DisplayMemberPath = "Name";

            //Bind One positional operations (to see in dropdown)
            OnePosOperations.ItemsSource = _helper.OnePosOperationsList;
            OnePosOperations.SelectedValuePath = "Id";
            OnePosOperations.DisplayMemberPath = "Name";

        }
        #endregion "ctor"
              
        //Prevent user add text in inputs
        public void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            e.Handled = _helper.NumberValidation(e.Text);
        }        

       #region "Calculations"

        private void TwoPosCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (twoPosFrstNum.Text != "" && twoPosScndNum.Text != "" &&
                TwoPosOperations.SelectedItem != null)
            {
                var frstNum = twoPosFrstNum.Text;
                var scndNum = twoPosScndNum.Text;

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
                var number = onePosNum.Text;

                var selectedItem = (Operations)OnePosOperations.SelectedItem;
                var result = Caller("Calculator", ((OperationsEnum)(selectedItem.Id)).ToString(), number, "");

                OnePosResult.Text = result.ToString();
            }
            else
                MessageBox.Show("Խնդրում ենք լրացնել դաշտերը․․․");
        }

        #endregion "Calculations"
    }
}