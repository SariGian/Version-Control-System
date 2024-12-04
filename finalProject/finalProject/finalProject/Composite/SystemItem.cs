using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Memento;
using FinalProject.State;

namespace FinalProject.Composite;

internal abstract class SystemItem
{

    public string Name { get; set; }
    protected SystemItemState State { get; set; }
    private List<User> UsersReview { get; set; }
    public CareTakerHistory History { get; set; }

    public SystemItem(string name)
    {
        Name = name;
        State = new Draft(this);
        UsersReview = new();
    }
    public abstract string Open();
    public void ChangeState(SystemItemState state)
    {
        State = state;
    }
    public abstract string Commit();
    //public string ShowHistory()
    //{
    //    string s = "";
    //    stack<FileMemento> NewHistory= new H;
    //    while (s.Length > 0) { }
    //}

    public void AddReviewer(User user)
    {
        UsersReview.Add(user);
    }
    public void RemoveReviewer(User user)
    {
        UsersReview.Remove(user);
    }
    public string ReqestReview()
    {
        return State.RequestReview();

    }
    public abstract string UndoTheCommit();
    public abstract string Merge(SystemItem item);

    public void NotifyReviews()
    {
        foreach (var review in UsersReview)
        {
            review.Update();
        }
    }
    public abstract void Add();








}
