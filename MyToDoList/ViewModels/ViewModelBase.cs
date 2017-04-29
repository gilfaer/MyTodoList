using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MyToDoList.Annotations;

namespace MyToDoList.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        //This method for setting view model properties was developed by Phillip Wells.  
        //http://www.elegant-software.net/2013/06/best-practice-for-implementing-inotifypropertychanged.html
        protected void SetProperty<T>(ref T property, T value,  [CallerMemberName] string propertyName = null)
        {
            if (Equals(property, value))
                return;
            property = value;
            OnPropertyChanged(propertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
