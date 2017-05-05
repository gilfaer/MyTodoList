using System;
using System.Windows.Input;

namespace MyToDoList.Commands
{
    //Modified from http://stackoverflow.com/questions/22285866/why-relaycommand and
    //http://onewindowsdev.com/?p=32
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke( parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            if(!CanExecute(parameter))
                return;
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
