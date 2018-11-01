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

namespace OperatorTaxi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window1 _window1;
        public Window2 _window2;
        public ViewModel a;

        public MainWindow()
        {
            InitializeComponent();
            a = new ViewModel("Orders.txt", "Taxists.txt");
            this.DataContext = a;
        }

        private void AddTaxi(object sender, RoutedEventArgs e)
        {
            _window1 = new Window1();
            _window1.DataContext = a;
            _window1.Show();
        }

        private void AddOrder(object sender, RoutedEventArgs e)
        {
            _window2 = new Window2();
            _window2.Show();
        }

        private void DeleteOrder(object sender, RoutedEventArgs e)
        {
            a.DeleteOrder();
            
        }

        private void SaveData(object sender, RoutedEventArgs e)
        {
            a.Save();
        }

        private void UploadData(object sender, RoutedEventArgs e)
        {
            a.Upload();
        }
    }
}
