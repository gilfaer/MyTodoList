using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private UserViewModel _user;

        public UserViewModel User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        private ObservableCollection<ProjectViewModel> _projects;

        public ObservableCollection<ProjectViewModel> Projects
        {
            get => _projects;
            set => SetProperty(ref _projects, value);
        }
    }
}
