using FinalProject.Composite;
using FinalProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Command
{
    internal class MergeCommand : systemItemCommand
    {
        SystemItem item;
        public MergeCommand(SystemItem systemItem ,SystemItem item) : base(systemItem)
        {
            this.item = item;
        }
        public override string Execute()
        {
            return SystemItem.Merge(item);
        }
    }
}
