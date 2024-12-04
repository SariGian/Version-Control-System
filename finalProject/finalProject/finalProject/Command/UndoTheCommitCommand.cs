using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Command
{
    internal class UndoTheCommitCommand : systemItemCommand
    {
        public UndoTheCommitCommand(SystemItem systemItem) : base(systemItem)
        {
        }

        public override string Execute()
        {
            return SystemItem.UndoTheCommit();
        }
    }
}
