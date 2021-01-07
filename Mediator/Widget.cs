using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Widget
    {
        public DialogDirector director;
        public Widget(DialogDirector dialogDirector)
        {
            this.director = dialogDirector;
        }

        public void Changed()
        {
            director.WidgetChanged(this);
        }
        
    };

    public class ListBox : Widget {
        public List<string> listItems;
        public int index = -1;
        public ListBox(DialogDirector dialogDirector): base(dialogDirector){}

        public string GetSelection()
        {
            if (listItems.Count == 0) return null;
            return listItems[index];
        }
        public void SetList(List<string> listItems)
        {
            this.listItems = listItems;
        }

        public void Choose(int index)
        {
            if (index < 0 || index > listItems.Count - 1) return;
            this.index = index;
            this.Changed();
        }

        public void Search(string entryText)
        {
            string res = "";
            for(int i = 0; i < listItems.Count; i++)
            {
                if (listItems[i].ToLower().Contains(entryText.ToLower()))
                {
                    Console.WriteLine("Found matched item: " + listItems[i]);
                    return;
                }
            }

            Console.WriteLine("No matched item");
        }
   
    };

    public class Entry : Widget
    {
        public string text;
        public Entry(DialogDirector dialogDirector) : base(dialogDirector) { }

        public string GetText()
        {
            return text;
        }
        public void SetText(string text)
        {
            this.text = text;
            Console.WriteLine("Entry's text is " + text);
        }

        public void Enter(string text)
        {
            this.text = text;
            this.Changed();
        }

    };
}
