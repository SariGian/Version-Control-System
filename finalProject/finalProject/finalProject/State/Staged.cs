using FinalProject.Composite;
using FinalProject.Memento;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinalProject.State
{
    internal class Staged : SystemItemState
    {

        public Staged(SystemItem systemItem) : base(systemItem)
        {
        }

        public override string Commit_file()
        {

            SystemItem.History.Push(new FileMemento(((FinalProject.Composite.File)SystemItem).Content));

            SystemItem.ChangeState(new Commited(SystemItem));
            return $"the file {SystemItem.Name} had commited successfuly:)";
        }
        public override string Commit_folder()
        {

            SystemItem.History.Push(new FolderMemento(((Folder)SystemItem).Items));
            
            SystemItem.ChangeState(new Commited(SystemItem));
            return $"the file {SystemItem.Name} had commited successfuly:)";
        }



       

        
        public override string Merge_file(SystemItem item)
        {
            throw new NotImplementedException();
        }

       

        public override string Merge_folder(SystemItem item)
        {
            throw new NotImplementedException();
        }

        public override string RequestReview()
        {
            throw new NotImplementedException();
        }



        public override string UndoTheCommit_file()
        {
            throw new NotImplementedException();
        }

        public override string UndoTheCommit_folder()
        {
            throw new NotImplementedException();
        }
    }
}
