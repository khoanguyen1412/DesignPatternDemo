using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class PlasticFactory : FurnitureAbstractFactory
    {
        public override IChair createChair()
        {
            return new PlasticChair();
        }

        public override ITable createTable()
        {
            return new PlasticTable();
        }
    }
}
