using System;

namespace FactoryMethod
{
    class Client
    {
        static void Main(string[] args)
        {
            IBank bank = BankFactory.getBank(BankType.TPBANK);
            Console.WriteLine(bank.getBankName());
        }
    }
}
