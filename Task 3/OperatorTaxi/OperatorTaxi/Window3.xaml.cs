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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void AddTaxist(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)App.Current.MainWindow;
            if (this.Model.Text != "" && this.Number.Text != "")
            {
                try
                {
                    mainWindow.a.Taxists.Add(new Taxist(this.Model.Text, this.Number.Text, false));
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильно введені дані");
                }
            }
            else
            {
                MessageBox.Show("Ви не ввели всі дані");
            }
        }
    }
}
