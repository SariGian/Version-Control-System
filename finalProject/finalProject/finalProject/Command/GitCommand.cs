using FinalProject.Composite;
using FinalProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Command
{
    internal abstract class systemItemCommand
    {
        protected SystemItem SystemItem { get; set; }
        public systemItemCommand(SystemItem systemItem)
        {
            SystemItem = systemItem;
        }
        public abstract string Execute();
    }
}
