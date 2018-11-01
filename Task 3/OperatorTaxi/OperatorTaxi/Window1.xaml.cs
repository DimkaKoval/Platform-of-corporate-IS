//-----------------------------------------------------------------------
// <copyright file="Window1.xaml.cs" company="The Four Shchews">
// (c)TFS inc.
// </copyright>
//-----------------------------------------------------------------------

namespace OperatorTaxi
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for Window1.xml
    /// </summary>
    public partial class Window1 : Window
    {
        /// <summary>
        /// Main Window
        /// </summary>
        private MainWindow mainWindow = (MainWindow)App.Current.MainWindow;

        /// <summary>
        /// Third window
        /// </summary>
        private Window3 window3;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Window1"/> class.
        /// First window
        /// </summary>
        public Window1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Add the driver to the order
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void AddTaxi(object sender, RoutedEventArgs e)
        {
            if (this.mainWindow.a.SelectedOrder != null && this.mainWindow.a.SelectedTaxi != null)
            {
                if (this.mainWindow.a.SelectedTaxi.Busy == false)
                {
                    this.mainWindow.a.SelectedTaxi.Busy = true;
                    this.mainWindow.a.SelectedOrder.Status = Status.Appointed;
                    this.mainWindow.a.SelectedOrder.CarNumber = this.mainWindow.a.SelectedTaxi.Number;
                    this.mainWindow.orderListView.Items.Refresh();
                    this.Taxists.Items.Refresh();
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

        /// <summary>
        /// Add driver
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument  value</param>
        private void AddTaxist(object sender, RoutedEventArgs e)
        {
            this.window3 = new Window3();
            this.window3.Show();
        }

        /// <summary>
        /// Delete driver
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void DeleteTaxist(object sender, RoutedEventArgs e)
        {
            this.mainWindow.a.DeleteTaxist();
            this.mainWindow.orderListView.Items.Refresh();
        }
    }
}
