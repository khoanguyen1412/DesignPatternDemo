using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class DialogDirector
    {
        public abstract void WidgetChanged(Widget widget);
        public abstract void AddWidget(Widget widget);
    };

}
