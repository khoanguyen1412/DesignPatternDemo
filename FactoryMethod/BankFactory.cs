using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public enum BankType
    {
        TPBANK,
        VIETCOMBANK
    }
    public class BankFactory
    {
        private BankFactory()
        {
        }

        public static IBank getBank(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.TPBANK:
                    return new TPBank();

                case BankType.VIETCOMBANK:
                    return new VietComBank();

                default:
                    throw new Exception("This bank type is unsupported");
            }
        }
    }
}
