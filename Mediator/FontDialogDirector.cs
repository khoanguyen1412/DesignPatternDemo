using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class FontDialogDirector : DialogDirector
    {
        ListBox listBox;
        Entry entry;
        int count = 0;
        public FontDialogDirector()
        {
        }

        public override void AddWidget(Widget widget)
        {
            if (widget.GetType().Name == "ListBox")
                listBox = (ListBox)widget;
            else
                entry = (Entry)widget;
        }


        public override void WidgetChanged(Widget changedWidget)
        {
            count++;
            Console.WriteLine(count+": ");
            if (changedWidget == listBox) //List box is changing
            {
                Console.WriteLine("ListBox changed:");
                entry.SetText(listBox.GetSelection());
            }
            else //Entry is changing
            {
                Console.WriteLine("Entry's text changed:");
                listBox.Search(entry.GetText());
            }
            Console.WriteLine();
        }
    }
}
