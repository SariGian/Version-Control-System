using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Memento
{
    internal class FileMemento : SystemItemMemento
    {
        public string Content {  get; }
        public FileMemento(string content)
        {
            Content = content;
        }
        public override void Restore()
        {
            throw new NotImplementedException();
        }
    }
}
