using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class FurnitureAbstractFactory
    {
        public abstract IChair createChair();

        public abstract ITable createTable();

    }
}
