using System;
using System.Collections.Generic;

namespace Mediator
{
    class Client
    {
        static void Main(string[] args)
        {
            DialogDirector fontMediator = new FontDialogDirector();

            ListBox myListBox = new ListBox(fontMediator);
            List<string> data = new List<string> { "Arial", "Comic Sans", "Athletic","Airborne" };
            myListBox.SetList(data);

            Entry myEntry = new Entry(fontMediator);

            fontMediator.AddWidget(myListBox);
            fontMediator.AddWidget(myEntry);

            myListBox.Choose(2);
            myEntry.Enter("ic");

        }
    }
}
