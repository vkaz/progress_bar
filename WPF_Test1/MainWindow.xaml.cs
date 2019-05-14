using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPF_Test1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            pbStatus.Value = sl.Value;
            string str = sl.Value.ToString("0.00") + "%";
            lb.Content = lb1.Content = str.Replace(',', '.');
        }
    }
}
