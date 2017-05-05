using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Autofac;
using Autofac.Core.Lifetime;
using MyToDoList.Mediator;

namespace MyToDoList.IoC
{
    public class IoCFrame : Frame
    {
        private readonly ContainerBuilder _builder;

        public static IContainer Container { get; private set; }

        public IoCFrame()
        {
            _builder = new ContainerBuilder();

            RegisterTypes(_builder);
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<Mediator.Mediator>().As<IMediator>().InstancePerLifetimeScope();
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);

            Container = _builder.Build();
        }
    }
}
