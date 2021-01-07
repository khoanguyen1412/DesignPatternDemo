using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WoodChair : IChair
    {
        public void create()
        {
            Console.WriteLine("Create wood table");
        }
    }
}
