<<<<<<< HEAD
﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

/// <summary>
/// Namespace WpfApp
/// </summary>
namespace WpfApp
{
    /// <summary>
    /// Class for drawin ellipse
    /// </summary>
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Ellipses colection
        /// </summary>
        public ObservableCollection<Ellipse> ellipses;

        /// <summary>
        /// Field for drawing
        /// </summary>
        public Canvas canvasDrawingArea;

        /// <summary>
        /// If the field is true then you can perform it
        /// </summary>
        private bool canExecute;

        /// <summary>
        /// Implementation
        /// </summary>
        private ICommand newFile;

        /// <summary>
        /// Implementation
        /// </summary>
        private ICommand openFile;

        /// <summary>
        /// Implementation
        /// </summary>
        private ICommand saveFile;

        /// <summary>
        /// Assign values to objects
        /// </summary>
        public ApplicationViewModel()
        {
            this.ellipses = new ObservableCollection<Ellipse>();
            this.canvasDrawingArea = new Canvas();
            this.canExecute = true;
        }

        /// <summary>
        /// Create new file
        /// </summary>
        public ICommand NewFile
        {
            get
            {
                return this.newFile ?? (this.newFile = new CommandHandler(() => NewFileExecute(), this.canExecute));
            }
        }

        /// <summary>
        /// Download ellipse from file
        /// </summary>
        public ICommand OpenFile
        {
            get
            {
                return this.openFile ?? (this.openFile = new CommandHandler(() => OpenFileExecute(), this.canExecute));
            }
        }

        /// <summary>
        /// Save ellipse in file
        /// </summary>
        public ICommand SaveFile
        {
            get
            {
                return this.saveFile ?? (this.saveFile = new CommandHandler(() => SaveFileExecute(), this.canExecute));
            }
        }

        /// <summary>
        /// Event when property was changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            ////if (PropertyChanged != null)
            ////{
            ////    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            ////}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Create new file with drawing area
        /// </summary>
        public void NewFileExecute()
        {
            this.canvasDrawingArea = new Canvas();
            this.ellipses.Clear();
        }

        /// <summary>
        /// Open xml file
        /// </summary>
        public void OpenFileExecute()
        {
            this.canvasDrawingArea = new Canvas();
            this.ellipses.Clear();
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Xml files (*.xml)|*.xml"
            };
            if (dialog.ShowDialog() == true)
            {
                this.ellipses.Clear();
                this.ellipses = FileOperations.Deserialize(dialog.FileName);
            }
        }

        /// <summary>
        /// Save information in xml file
        /// </summary>
        public void SaveFileExecute()
        {
            try
            {
                if (this.ellipses.Count == 0)
                {
                    throw new ArgumentNullException("There aren't shapes on the drawing area");
                }
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "Xml files (*.xml)|*.xml"
                };
                if (dialog.ShowDialog() == true)
                {
                    FileOperations.Serialize(this.ellipses, dialog.FileName);
                }
            }
            catch (ArgumentNullException exp)
            {
                MessageBox.Show(exp.ParamName);
            }
        }

    }
}
=======
﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace WpfApp
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Ellipse> ellipses;
        public Canvas canvasDrawingArea;
        private bool canExecute;
        private ICommand newFile;
        private ICommand openFile;
        private ICommand saveFile;

        public ApplicationViewModel()
        {
            this.ellipses = new ObservableCollection<Ellipse>();
            this.canvasDrawingArea = new Canvas();
            this.canExecute = true;
        }

        public ICommand NewFile
        {
            get
            {
                return this.newFile ?? (this.newFile = new CommandHandler(() => NewFileExecute(), this.canExecute));
            }
        }

        public ICommand OpenFile
        {
            get
            {
                return this.openFile ?? (this.openFile = new CommandHandler(() => OpenFileExecute(), this.canExecute));
            }
        }

        public ICommand SaveFile
        {
            get
            {
                return this.saveFile ?? (this.saveFile = new CommandHandler(() => SaveFileExecute(), this.canExecute));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            ////if (PropertyChanged != null)
            ////{
            ////    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            ////}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void NewFileExecute()
        {
            this.canvasDrawingArea = new Canvas();
            this.ellipses.Clear();
        }

        public void OpenFileExecute()
        {
            this.canvasDrawingArea = new Canvas();
            this.ellipses.Clear();
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Xml files (*.xml)|*.xml"
            };
            if (dialog.ShowDialog() == true)
            {
                this.ellipses.Clear();
                this.ellipses = FileOperations.Deserialize(dialog.FileName);
            }
        }

        public void SaveFileExecute()
        {
            try
            {
                if (this.ellipses.Count == 0)
                {
                    throw new ArgumentNullException("There aren't shapes on the drawing area");
                }
                SaveFileDialog dialog = new SaveFileDialog
                {
                    Filter = "Xml files (*.xml)|*.xml"
                };
                if (dialog.ShowDialog() == true)
                {
                    FileOperations.Serialize(this.ellipses, dialog.FileName);
                }
            }
            catch (ArgumentNullException exp)
            {
                MessageBox.Show(exp.ParamName);
            }
        }

    }
}
>>>>>>> 586a2d267c15da5e2edb0451a1bb8364efd74dc9
