using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WoodTable : ITable
    {
        public void create()
        {
            Console.WriteLine("Create wood table");
        }
    }
}
