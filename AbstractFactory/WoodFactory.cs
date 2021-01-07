using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WoodFactory : FurnitureAbstractFactory
    {
        public override IChair createChair()
        {
            return new WoodChair();
        }

        public override ITable createTable()
        {
            return new WoodTable();
        }
    }
}
