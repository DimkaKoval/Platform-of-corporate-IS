<<<<<<< HEAD
=======
<<<<<<< HEAD
﻿//-----------------------------------------------------------------------
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

<<<<<<< HEAD
=======
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

>>>>>>> 05b902d11824351483b3ec598145b18ecc370c8e
namespace OperatorTaxi
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void AddOrder(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)App.Current.MainWindow;
            if (this.startPoint.Text != "" && this.endPoint.Text != "" && this.count.Text != "")
            {
                try
                {
                    mainWindow.a.Orders.Add(new Order(this.startPoint.Text, this.endPoint.Text, Convert.ToInt32(this.count.Text), status.NotAppointed, "------"));
<<<<<<< HEAD
                    this.Close();
                }
                catch(Exception)
=======
>>>>>>> 69475dd58d1dd7cfbd41bacb19a43a91ce78a4ba
                    this.Close();
                }
                catch (Exception)
>>>>>>> 05b902d11824351483b3ec598145b18ecc370c8e
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

>>>>>>> 69475dd58d1dd7cfbd41bacb19a43a91ce78a4ba
>>>>>>> 05b902d11824351483b3ec598145b18ecc370c8e
