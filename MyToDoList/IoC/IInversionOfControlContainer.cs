using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace MyToDoList.IoC
{
    public interface IInversionOfControlContainer
    {
        IContainer Container { get; set; }
    }
}
