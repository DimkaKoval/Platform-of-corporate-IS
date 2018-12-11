<<<<<<< HEAD
=======
<<<<<<< HEAD
﻿//-----------------------------------------------------------------------
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
=======
>>>>>>> 05b902d11824351483b3ec598145b18ecc370c8e
﻿using System;
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
<<<<<<< HEAD
=======
>>>>>>> 69475dd58d1dd7cfbd41bacb19a43a91ce78a4ba
>>>>>>> 05b902d11824351483b3ec598145b18ecc370c8e
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
