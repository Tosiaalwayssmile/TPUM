using System;
using System.Windows.Input;

namespace ViewLayer.Commands
{
    public class Command : ICommand
    {
        private readonly Action _action;
        public event EventHandler CanExecuteChanged;

        public Command(Action action)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action));
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            _action.Invoke();
        }
    }
}