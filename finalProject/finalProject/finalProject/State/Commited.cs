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
    internal class Commited : SystemItemState
    {
        public Commited(SystemItem SystemItem) : base(SystemItem)
        {
        }

        public override string Commit_file()
        {
            return $"Nothing to commit.";
        }
        public override string Commit_folder()
        {
            return $"Nothing to commit.";
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
            SystemItem.NotifyReviews();
            SystemItem.ChangeState(new UnderReview(SystemItem));
            return $"";
        }


        public override string UndoTheCommit_file()
        {
            ((FinalProject.Composite.File)SystemItem).Content = ((FileMemento)SystemItem.History.Pop()).Content;
            return $"the file {SystemItem.Name} returned to its previous state.";
        }
       

        public override string UndoTheCommit_folder()
        {
            ((Folder)SystemItem).Items = ((FolderMemento)SystemItem.History.Pop()).Content;
            return $"the folder {SystemItem.Name} returned to its previous state.";
        }
    }
}
