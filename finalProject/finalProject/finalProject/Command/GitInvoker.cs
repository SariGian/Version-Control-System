using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Command
{
    internal class GitInvoker
    {
        Queue<systemItemCommand> commandQueue;
        public GitInvoker()
        {
            commandQueue = new Queue<systemItemCommand>();
        }
        public void PlacesystemItemRequest(systemItemCommand command)
        {
            commandQueue.Enqueue(command);
        }
        public string DoJob()
        {
            string s = "";
            while (commandQueue.Count > 0)
            {
                var commandToDo = commandQueue.Dequeue();
                s += commandToDo.Execute();
                s += "\n";
            }
            return s;
        }
    }
}
