using System;
using System.Windows.Input;

namespace MyToDoList.Commands
{
    //Modified from http://stackoverflow.com/questions/22285866/why-relaycommand and
    //http://onewindowsdev.com/?p=32
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute;
        private readonly Predicate<T> _canExecute;

        public RelayCommand(Action<T> execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke((T) parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            if(!CanExecute(parameter))
                return;
            _execute((T) parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
