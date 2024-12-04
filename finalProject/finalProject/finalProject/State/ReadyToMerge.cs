using FinalProject.Composite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State;

internal class ReadyToMerge : SystemItemState
{
    public ReadyToMerge(SystemItem systemItem) : base(systemItem)
    {

    }

    public override string Commit_file()
    {
        throw new NotImplementedException();
    }
    public override string Commit_folder()
    {
        throw new NotImplementedException();
    }

    public override string Merge_file(SystemItem item)
    {
        SystemItem = item;
        return $"the files {SystemItem.Name} and {item.Name} had merged. ";
       
    }

    public override string Merge_folder(SystemItem item)
    {

        SystemItem = item;
        return $"the folders {SystemItem.Name} and {item.Name} had merged. ";
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
