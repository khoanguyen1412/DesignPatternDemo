using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class FlyState : IState
    {
        public void Move()
        {
            Console.WriteLine("Mario Flying");
        }
    }
}
