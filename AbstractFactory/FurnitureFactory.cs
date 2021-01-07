using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public enum MaterialType
    {
        FLASTIC, WOOD
    }
    public class FurnitureFactory
    {
        private FurnitureFactory()
        {

        }
        public static FurnitureAbstractFactory getFactory(MaterialType materialType)
        {
            switch (materialType)
            {
                case MaterialType.FLASTIC:
                    return new PlasticFactory();
                case MaterialType.WOOD:
                    return new WoodFactory();
                default:
                    throw new Exception("This furniture is unsupported ");
            }
        }
    }
}
