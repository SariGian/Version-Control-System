using FinalProject.Composite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.State;

internal class UnderReview : SystemItemState
{
    public UnderReview(SystemItem SystemItem) : base(SystemItem)
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