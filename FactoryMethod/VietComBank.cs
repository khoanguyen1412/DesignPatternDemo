using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class VietComBank : IBank
    {
        public string getBankName()
        {
            return "VietComBank";
        }
    }
}
