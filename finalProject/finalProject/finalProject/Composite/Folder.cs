using FinalProject.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Composite;

internal class Folder : SystemItem
{
    List<SystemItem> changes = new List<SystemItem>();
    public List<SystemItem> Items { get; set; }
    public Folder(string name) : base(name)
    {
        Items = new List<SystemItem>();
    }
    public void AddSystemItem(SystemItem item)
    {
        State = new Draft(this);
        changes.Add(item);
    }
    public void RemoveSystemItem(SystemItem item)
    {
        State = new Draft(this);
        changes.Remove(item);
    }

    public override string Commit()
    {
        return State.Commit_folder();
    }



    public override string Open()
    {
        string s = "";
        foreach (SystemItem item in Items)
        {
            s += item.Name;
            s += "\n";
        }

        return s;
    }

    

    public override string UndoTheCommit()
    {
        return State.UndoTheCommit_folder();
    }

    public override string Merge(SystemItem item)
    {
        return State.Merge_folder(item);
    }

    public override void Add()
    {
        Items.Add(this);

    }
}
