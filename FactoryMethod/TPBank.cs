using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TPBank : IBank
    {
        public string getBankName()
        {
            return "TPBank";
        }
    }
}
