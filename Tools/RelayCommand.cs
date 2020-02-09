using System;
using System.Windows.Input;

namespace PathfinderBuissness.Tools
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<object> action;
        private readonly Func<object, bool> canExecute;
        private readonly string message;

        public RelayCommand(Action<object> action)
            : this(action, o => true, null)
        { }

        public RelayCommand(Action<object> action, string message)
        : this(action, o => true, message)
        { }

        public RelayCommand(Action<object> action, Func<object, bool> canExecute, string message)
        {
            this.action = action;
            this.canExecute = canExecute;
            this.message = message;
        }

        public bool CanExecute(object parameter) => canExecute(parameter);
        public void Execute(object parameter)
        {
            if (parameter != null)
            {
                action(parameter);
            }
            else
            {
                action(null);
            }
        }
    }
}