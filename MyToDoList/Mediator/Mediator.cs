using System;
using System.Collections.Generic;
using System.Linq;

namespace MyToDoList.Mediator
{
    public class Mediator : IMediator
    {
        private readonly List<Listener> _registeredListeners = new List<Listener>();

        private static readonly object _syncrhonizationContext = new object();

        public void RegisterListener(string message, Delegate callBack)
        {
            lock (_syncrhonizationContext)
            {
                if (_registeredListeners.Any(i => i.Topic.Equals(message)))
                {
                    var listener = _registeredListeners.First(i => i.Topic.Equals(message));
                    listener.CallBacks.Add(callBack);
                }
                else
                {
                    _registeredListeners.Add(new Listener
                    {
                        Topic = message,
                        CallBacks = new List<Delegate> { callBack }
                    });
                }
            }
        }

        public void Notify(string message, params object[] parameters)
        {
            lock (_syncrhonizationContext)
            {
                if (_registeredListeners.Any(i => i.Topic.Equals(message)))
                {
                    var listener = _registeredListeners.First(i => i.Topic.Equals(message));
                    foreach (var callback in listener.CallBacks)
                    {
                        callback.DynamicInvoke(parameters);
                    }
                }
            }
        }
    }
}
