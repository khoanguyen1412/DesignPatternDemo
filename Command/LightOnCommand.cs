using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.switchOn();
        }
    }
}
