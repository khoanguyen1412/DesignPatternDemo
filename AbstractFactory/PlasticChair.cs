using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class PlasticChair : IChair
    {
        public void create()
        {
            Console.WriteLine("Create plastic chair");
        }
    }
}
