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
using System.Windows.Shapes;

namespace OperatorTaxi
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow mainWindow = (MainWindow)App.Current.MainWindow;
        public Window3 _window3;

        public Window1()
        {
            InitializeComponent();
        }

        private void AddTaxi(object sender, RoutedEventArgs e)
        {
            if (mainWindow.a.SelectedOrder != null && mainWindow.a.SelectedTaxi != null)
            {
                if (mainWindow.a.SelectedTaxi.Busy == false)
                {
                    mainWindow.a.SelectedTaxi.Busy = true;
                    mainWindow.a.SelectedOrder.Status = status.Appointed;
                    mainWindow.a.SelectedOrder.CarNumber = mainWindow.a.SelectedTaxi.Number;
                    mainWindow.orderListView.Items.Refresh();
                    Taxists.Items.Refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Виберіть водія який не є зайнятий");
                }
            }
            else
            {
                MessageBox.Show("Для того щоб назначити водія на замовлення необхідно вибрати замовлення і вибрати водія");
            }
        }

        private void AddTaxist(object sender, RoutedEventArgs e)
        {
            _window3 = new Window3();
            _window3.Show();
        }

        private void DeleteTaxist(object sender, RoutedEventArgs e)
        {
            mainWindow.a.DeleteTaxist();
            mainWindow.orderListView.Items.Refresh();
        }
    }
}
