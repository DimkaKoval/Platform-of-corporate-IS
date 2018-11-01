namespace OperatorTaxi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.ComponentModel;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;

    public class ViewModel : INotifyPropertyChanged
    {
        private string path1;
        private string path2;
        private Order selectedOrder;
        private Taxist selectedTaxi;
        private ObservableCollection<Order> orders;
        private ObservableCollection<Taxist> taxists;

        public string Path1
        {
            get
            {
                return path1;
            }
            set
            {
                path1 = value;
            }
        }

        public string Path2
        {
            get
            {
                return path2;
            }
            set
            {
                path2 = value;
            }
        }

        public Order SelectedOrder
        {
            get
            {
                return selectedOrder;
            }
            set
            {
                selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }

        public Taxist SelectedTaxi
        {
            get
            {
                return selectedTaxi;
            }
            set
            {
                selectedTaxi = value;
                OnPropertyChanged("SelectedTaxi");
            }
        }

        public ObservableCollection<Order> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
                OnPropertyChanged("Orders");
            }
        }

        public ObservableCollection<Taxist> Taxists
        {
            get
            {
                return taxists;
            }
            set
            {
                taxists = value;
                OnPropertyChanged("Taxists");
            }
        }

        public ViewModel(string Path1, string Path2)
        {
            this.Path1 = Path1;
            this.Path2 = Path2;
            Upload();
        }

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

        public void DeleteOrder()
        {
            if (SelectedOrder.Status == status.Appointed)
            {
                foreach(var i in Taxists)
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

        public void DeleteTaxist()
        {
            if (SelectedTaxi.Busy == true)
            {
                foreach (var i in Orders)
                {
                    if (SelectedTaxi.Number == i.CarNumber)
                    {
                        i.CarNumber = "------";
                        i.Status = status.NotAppointed;
                    }
                }
            }
            Taxists.Remove((SelectedTaxi));
            SelectedTaxi = Taxists.Count != 0 ? Taxists.First() : null;
        }

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
            status stat;
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
                    stat = line[3] == "Appointed" ? status.Appointed : status.NotAppointed;
                    if (line.Length == 5 && stat == status.Appointed)
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