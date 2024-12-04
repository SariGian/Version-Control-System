using FinalProject.Composite;
using FinalProject.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

internal class Branch : ICloneable
{
    private static int ID = 1;
    public string Name { get; set; }
    public int BranchId { get; }
    public List<Branch> Branches { get; set; }
    public Branch Parent { get; set; }
    public List<SystemItem> SystemItems { get; set; }
    FileFactory FileFactory { get; set; }
    public Branch(string name, Branch parent = null)
    {
        Branches = new List<Branch>();
        Parent = parent;
        Name = name;
        BranchId = ID++;
        SystemItems = new();
    }
    public Branch( Branch parent, List<SystemItem> systemItems)
    {
        Branches = new List<Branch>();
        Parent = parent;
        BranchId = ID++;
        SystemItems = systemItems;
        FileFactory = FileFactory.GetInstance();
    }
    //🥰
    public string CreateBranch(string name)
    {
        Branches.Add((Branch)Clone());
        Branches[Branches.Count - 1].Name = name;
        return $"the branch {name} had created successfully.";
    }
    public void RemoveBranch(Branch branch)
    {
        Branches.Remove(branch);
    }
    public string AddFile(SystemItem file)
    {
        SystemItems.Add(file);
        return $"the file {file.Name} had added successfully.";
    }
    public void RemoveFile(SystemItem file)
    {
        SystemItems.Remove(file);
    }
    public void ChangeFile(string name, string content)
    {
        FinalProject.Composite.File file  = FileFactory.GetFile(name,BranchId);
        file.Content = content;
    }
    public object Clone()
    {
        return new Branch(this,new(SystemItems));
    }
}
