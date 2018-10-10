using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;


/// <summary>
/// Namespace WpfApp
/// </summary>
namespace WpfApp
{
    /// <summary>
    /// Class for handling commands
    /// </summary>
    public class CommandHandler : ICommand
    {
        /// <summary>
        /// Contain some action
        /// </summary>
        private Action action;

        /// <summary>
        /// Contain true if action can be perfomed
        /// and contain false or not
        /// </summary>
        private bool canExecute;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="act">What action</param>
        /// <param name="canExe">Perfomed?</param>
        public CommandHandler(Action act, bool canExe)
        {
            this.action = act;
            this.canExecute = canExe;
        }

        /// <summary>
        /// Event controler
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        /// <summary>
        /// Object can or can`t execute
        /// </summary>
        /// <param name="parameter">CanExecute</param>
        /// <returns>true or false</returns>
        public bool CanExecute(object parameter)
        {
            return this.canExecute;
        }

        /// <summary>
        /// Do action
        /// </summary>
        /// <param name="parameter">Which obj must do act</param>
        public void Execute(object parameter)
        {
            this.action();
        }
    }
}
