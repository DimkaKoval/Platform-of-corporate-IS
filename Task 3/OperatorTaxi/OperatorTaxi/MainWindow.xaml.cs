//-----------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="The Four Shchews">
// (c)TFS inc.
// </copyright>
//-----------------------------------------------------------------------

namespace OperatorTaxi
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// First window
        /// </summary>
        public Window1 window1;

        /// <summary>
        /// Second window
        /// </summary>
        public Window2 window2;

        /// <summary>
        /// Pattern
        /// </summary>
        public ViewModel a;

        /// <summary>
        /// Initializes a new instance of the <see cref = "MainWindow"/> class.
        /// Main window
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            a = new ViewModel("Orders.txt", "Taxists.txt");
            this.DataContext = a;
        }

        /// <summary>
        /// Add new driver
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void AddTaxi(object sender, RoutedEventArgs e)
        {
            this.window1 = new Window1();
            this.window1.DataContext = a;
            this.window1.Show();
        }

        /// <summary>
        /// Add new order
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void AddOrder(object sender, RoutedEventArgs e)
        {
            this.window2 = new Window2();
            this.window2.Show();
        }

        /// <summary>
        /// Delete order
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void DeleteOrder(object sender, RoutedEventArgs e)
        {
            a.DeleteOrder();
        }

        /// <summary>
        /// Save information in file
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void SaveData(object sender, RoutedEventArgs e)
        {
            a.Save();
        }

        /// <summary>
        /// Load information from file
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void UploadData(object sender, RoutedEventArgs e)
        {
            a.Upload();
        }
    }
}
