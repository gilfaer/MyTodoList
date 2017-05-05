using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoList.Mediator
{
    public class Listener
    {
        public string Topic { get; set; }
        public List<Delegate> CallBacks { get; set; }
    }
}