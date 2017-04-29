using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.ViewModels
{
    public class ProjectViewModel : ViewModelBase
    {
        private string _projectName;

        public string ProjectName
        {
            get => _projectName;
            set => SetProperty(ref _projectName, value);
        }
    }
}
