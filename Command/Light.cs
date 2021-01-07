using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Light
    {
        private Boolean on;
        public void switchOn()
        {
            on = true;
            Console.WriteLine("on");
        }

        public void switchOff()
        {
            on = false;
            Console.WriteLine("off");
        }
    }
}
