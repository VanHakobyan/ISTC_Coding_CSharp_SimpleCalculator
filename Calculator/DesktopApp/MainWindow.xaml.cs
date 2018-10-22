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
        List<string> Functions;

        public MainWindow()
        {
            InitializeComponent();
            Functions = new List<string>();

            MethodInfo[] methodInfos = typeof(Calculator).GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in methodInfos)
            {
                Functions.Add(item.Name);
            }

            Combo.ItemsSource = Functions;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
