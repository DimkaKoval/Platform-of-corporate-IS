//-----------------------------------------------------------------------
// <copyright file="Window2.xaml.cs" company="The Four Shchews">
// (c)TFS inc.
// </copyright>
//-----------------------------------------------------------------------

namespace OperatorTaxi
{
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for Window2.xml
    /// </summary>
    public partial class Window2 : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "Window2"/> class.
        /// Second window
        /// </summary>
        public Window2()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Method add new order
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void AddOrder(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)App.Current.MainWindow;
            if (this.startPoint.Text != string.Empty && this.endPoint.Text != string.Empty && this.count.Text != string.Empty)
            {
                try
                {
                    mainWindow.a.Orders.Add(new Order(this.startPoint.Text, this.endPoint.Text, Convert.ToInt32(this.count.Text), Status.NotAppointed, "------"));
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
