using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Memento;

internal class CareTakerHistory
{
    private Stack<SystemItemMemento> History { get; set; }
    //מה יהיה? לאה כל כך עיפה, וגם אני. וגם שרי. המצב נראה נואש....
    //לא, המצב יהיה טוב", אמרה לאה וחייכה חיוך של עייפים נורא"
    public SystemItemMemento Pop()
    {
        return History.Pop();
    }
    public void Push(SystemItemMemento item)
    {
        History.Push(item);
    }
    

    //!!!טוב, בואנה נמשיך. נו כבר
    //שי דוזנט נואו וואט טו דו, ביקוז איטס ורי הרד... אנד שי איז ורייי טיירד:(
}
