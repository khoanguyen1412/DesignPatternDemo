using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class PlasticTable : ITable
    {
        public void create()
        {
            Console.WriteLine("Create plastic table");
        }
    }
}
