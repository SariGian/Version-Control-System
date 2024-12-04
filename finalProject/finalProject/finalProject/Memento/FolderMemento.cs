using FinalProject.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Memento
{
    internal class FolderMemento : SystemItemMemento
    {
       public List<SystemItem> Content { get; }
        public FolderMemento(List<SystemItem> content)
        {
            Content = content;
        }
        public override void Restore()
        {
            
        }
    }//אי אי איאי לא יפה לבכות בקול גדול
}
