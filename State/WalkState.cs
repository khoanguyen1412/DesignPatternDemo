﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class WalkState : IState
    {
        public void Move()
        {
            Console.WriteLine("Mario Walking");

        }
    }
}
