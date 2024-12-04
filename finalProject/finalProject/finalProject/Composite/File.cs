using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Composite;

internal class File : SystemItem
{
    public string Content { get; set; }
    public DateTime ChangeDate { get; set; }
    public File(string name, string content) : base(name)
    {
        Content = content;
    }
    public File(string name) : base(name)
    {

    }
    public override string Commit()
    {
        return State.Commit_file();
    }


    public override string Open()
    {
        return Content;
    }

    //public override void ShowHistory()
    //{
    //    throw new NotImplementedException();
    //}

    public override string UndoTheCommit()
    {
        return State.UndoTheCommit_file();
    }

 

    public override void Add()
    {
        throw new NotImplementedException();
    }

    public override string Merge(SystemItem item)
    {
        return State.Merge_file(item);
    }
}
