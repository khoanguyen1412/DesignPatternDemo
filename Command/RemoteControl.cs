using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class RemoteControl
    {
        private ICommand command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void pressButton()
        {
            command.execute();
        }
    }
}
