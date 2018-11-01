//-----------------------------------------------------------------------
// <copyright file="ViewModel.cs" company="The Four Shchews">
// (c)TFS inc.
// </copyright>
//-----------------------------------------------------------------------

namespace OperatorTaxi
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;

    /// <summary>
    /// Custom command class. Implements <see cref = "INotifyPropertyChanged"/> interface
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        private string path1;

        /// <summary>
        /// 
        /// </summary>
        private string path2;

        /// <summary>
        /// Select order
        /// </summary>
        private Order selectedorder;

        /// <summary>
        /// Select taxi
        /// </summary>
        private Taxist selectedtaxi;

        /// <summary>
        /// Orders list
        /// </summary>
        private ObservableCollection<Order> orders;

        /// <summary>
        /// Taxists list
        /// </summary>
        private ObservableCollection<Taxist> taxists;

        /// <summary>
        /// Gets or sets value Path1 property
        /// </summary>
        public string Path1
        {
            get { return this.path1; }
            set { this.path1 = value; }
        }

        /// <summary>
        /// Gets or sets value Path2 property
        /// </summary>
        public string Path2
        {
            get { return this.path2; }
            set { this.path2 = value; }
        }

        /// <summary>
        /// Select order for taxist
        /// </summary>
        public Order SelectedOrder
        {
            get { return this.selectedorder; }

            set
            {
                this.selectedorder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }

        /// <summary>
        /// Select taxist for order
        /// </summary>
        public Taxist SelectedTaxi
        {
            get { return this.selectedtaxi; }
            set
            {
                this.selectedtaxi = value;
                OnPropertyChanged("SelectedTaxi");
            }
        }

        /// <summary>
        /// Gets or sets value Orders property
        /// </summary>
        public ObservableCollection<Order> Orders
        {
            get { return this.orders; }
            set
            {
                this.orders = value;
                OnPropertyChanged("Orders");
            }
        }

        /// <summary>
        /// Gets or sets value Taxists property
        /// </summary>
        public ObservableCollection<Taxist> Taxists
        {
            get { return this.taxists; }
            set
            {
                this.taxists = value;
                OnPropertyChanged("Taxists");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path1"></param>
        /// <param name="Path2"></param>
        public ViewModel(string Path1, string Path2)
        {
            this.Path1 = Path1;
            this.Path2 = Path2;
            Upload();
        }

        /// <summary>
        /// Save lists in file
        /// </summary>
        public void Save()
        {
            var lines1 = new string[Orders.Count];
            for (int i = 0; i < lines1.Length; ++i)
            {
                lines1[i] = Orders[i].StartPoint + " " + Orders[i].EndPoint + " " + Orders[i].Count + " " + Orders[i].Status + " " + Orders[i].CarNumber;
            }
            File.WriteAllLines(Path1, lines1);
            var lines2 = new string[Taxists.Count];
            for (int i = 0; i < lines2.Length; ++i)
            {
                lines2[i] = Taxists[i].CarModel + " " + Taxists[i].Number + " " + Taxists[i].Busy;
            }
            File.WriteAllLines(Path2, lines2);
        }

        /// <summary>
        /// Delete order from list
        /// </summary>
        public void DeleteOrder()
        {
            if (SelectedOrder.Status == Status.Appointed)
            {
                foreach (var i in Taxists)
                {
                    if (SelectedOrder.CarNumber == i.Number)
                    {
                        i.Busy = false;
                    }
                }
            }
            Orders.Remove((SelectedOrder));
            SelectedOrder = Orders.Count != 0 ? Orders.First() : null;
        }

        /// <summary>
        /// Delete taxist from list
        /// </summary>
        public void DeleteTaxist()
        {
            if (SelectedTaxi.Busy == true)
            {
                foreach (var i in Orders)
                {
                    if (SelectedTaxi.Number == i.CarNumber)
                    {
                        i.CarNumber = "------";
                        i.Status = Status.NotAppointed;
                    }
                }
            }
            Taxists.Remove((SelectedTaxi));
            SelectedTaxi = Taxists.Count != 0 ? Taxists.First() : null;
        }

        /// <summary>
        /// Load information from file
        /// </summary>
        public void Upload()
        {
            Orders = new ObservableCollection<Order>();
            if (!File.Exists(Path1))
            {
                throw new Exception("File1 does not exists.");
            }
            var lines = File.ReadAllLines(Path1, Encoding.UTF8);
            string[] line;
            string startPoint;
            string endPoint;
            int count;
            Status stat;
            string carNumber;

            for (int i = 0; i < lines.Length; ++i)
            {
                line = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (line.Length > 1)
                {
                    carNumber = "------";
                    startPoint = line[0];
                    endPoint = line[1];
                    count = Convert.ToInt32(line[2]);
                    stat = line[3] == "Appointed" ? Status.Appointed : Status.NotAppointed;
                    if (line.Length == 5 && stat == Status.Appointed)
                    {
                        carNumber = line[4];
                    }

                    Orders.Add(new Order(startPoint, endPoint, count, stat, carNumber));
                }
            }

            Taxists = new ObservableCollection<Taxist>();
            if (!File.Exists(Path2))
            {
                throw new Exception("File2 does not exists.");
            }
            lines = File.ReadAllLines(Path2, Encoding.UTF8);
            string carModel;
            string number;
            bool busy;

            for (int i = 0; i < lines.Length; ++i)
            {
                line = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (line.Length > 1)
                {
                    carModel = line[0];
                    number = line[1];
                    busy = Convert.ToBoolean(line[2]);

                    Taxists.Add(new Taxist(carModel, number, busy));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}