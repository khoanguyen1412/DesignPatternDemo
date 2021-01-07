using System;

namespace AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            FurnitureAbstractFactory factory = FurnitureFactory.getFactory(MaterialType.FLASTIC);

            IChair chair = factory.createChair();
            chair.create(); // Create plastic chair

            ITable table = factory.createTable();
            table.create(); // Create plastic table
        }
    }
}
