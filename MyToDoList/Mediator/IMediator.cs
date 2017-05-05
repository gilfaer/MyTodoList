using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.Mediator
{
    public interface IMediator
    {
        void RegisterListener(string message, Delegate callBack);
        void Notify(string message, params object[] parameters);
    }
}
