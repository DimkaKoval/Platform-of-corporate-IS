//-----------------------------------------------------------------------
// <copyright file="Window3.xaml.cs" company="The Four Shchews">
// (c)TFS inc.
// </copyright>
//-----------------------------------------------------------------------

namespace OperatorTaxi
{
    using System;
    using System.Windows;

    /// <summary>
    /// Interaction logic for Window3.xml
    /// </summary>
    public partial class Window3 : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "Window3"/> class.
        /// Third window
        /// </summary>
        public Window3()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Add new driver
        /// </summary>
        /// <param name="sender">Dispatcher</param>
        /// <param name="e">Event argument value</param>
        private void AddTaxist(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)App.Current.MainWindow;
            if (this.Model.Text != string.Empty && this.Number.Text != string.Empty)
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
